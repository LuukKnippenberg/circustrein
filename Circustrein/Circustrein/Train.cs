using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Circustrein;

namespace Circustrein
{
    class Train
    {
        public List<Wagon> ActualWagonList { get; private set; }
        public ReadOnlyCollection<Wagon> wagonList
        {
            get { return ActualWagonList.AsReadOnly(); }
        }

        public List<Animal> ActualAnimalList { get; private set; }
        public ReadOnlyCollection<Animal> animalList
        {
            get { return ActualAnimalList.AsReadOnly(); }
        }

        public Train()
        {
            ActualWagonList = new List<Wagon>();
            ActualAnimalList = new List<Animal>();
        }

        public void AddAnimal(string name, Animal.Diet diet, string sizeString)
        {
            int size;

            //Converts size to number for storage
            if (sizeString.ToLower() == "small")
            {
                size = 1;
            } 
            else if (sizeString.ToLower() == "medium")
            {
                size = 3;
            }
            else
            {
                size = 5;
            }

            ActualAnimalList.Add(new Animal(name, diet, size));
        }

        public void DistibuteAnimals()
        {
            ActualWagonList.Clear();
            List<Animal> animalListSorted = new List<Animal>();

            //Check if first wagon exists and creates if it doesn't.
            if (wagonList.Count == 0)
            {
                ActualWagonList.Add(new Wagon());
            }

            //Sort the animal list descending by size, this will allow the algorithm to place the large animals first.
            var orderBySize = from element in animalList orderby element.size descending orderby element.diet  select element;
            foreach(Animal animal in orderBySize)
            {
                animalListSorted.Add(animal);
            }

            //Loops through the animals and checks for available wagons, creates a new wagon if a suitable spot doesn't exist.
            for (int i = 0; i < animalListSorted.Count; i++)
            {

                bool addSuccess = true;
                for (int x = 0; x < wagonList.Count; x++)
                {
                    addSuccess = wagonList[x].AddAnimal(animalListSorted[i]);
                }

                if (!addSuccess)
                {
                    ActualWagonList.Add(new Wagon());
                    ActualWagonList[(ActualWagonList.Count - 1)].AddAnimal(animalListSorted[i]);
                }
            }
        }

        public void ClearLists()
        {
            ActualAnimalList = new List<Animal>();
            ActualWagonList = new List<Wagon>();
        }

    }
}
