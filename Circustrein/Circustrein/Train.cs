using System;
using System.Collections.Generic;
using System.Linq;
using Circustrein;

namespace Circustrein
{
    class Train
    {
        public List<Wagon> wagonList { get; private set; }
        public List<Animal> animalList { get; private set; }

        public Train()
        {
            wagonList = new List<Wagon>();
            animalList = new List<Animal>();
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

            animalList.Add(new Animal(name, diet, size));
        }

        public void DistibuteAnimals()
        {
            wagonList.Clear();
            List<Animal> animalListSorted = new List<Animal>();

            //Check if first wagon exists and creates if it doesn't.
            if (wagonList.Count == 0)
            {
                wagonList.Add(new Wagon());
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
                    wagonList.Add(new Wagon());
                    wagonList[(wagonList.Count - 1)].AddAnimal(animalListSorted[i]);
                }
            }
        }

        public void ClearLists()
        {
            animalList = new List<Animal>();
            wagonList = new List<Wagon>();
        }

    }
}
