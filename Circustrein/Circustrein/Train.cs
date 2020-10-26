using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Circustrein;

namespace Circustrein
{
    class Train
    {
        private List<Wagon> wagonList;
        public ReadOnlyCollection<Wagon> wagonListReadOnly
        {
            get { return wagonList.AsReadOnly(); }
        }

        private List<Animal> animalList;
        public ReadOnlyCollection<Animal> animalListReadOnly
        {
            get { return animalList.AsReadOnly(); }
        }

        public Train()
        {
            wagonList = new List<Wagon>();
            animalList = new List<Animal>();
        }

        public void AddAnimal(string name, Animal.Diets diet, Animal.Sizes size)
        {
            animalList.Add(new Animal(name, diet, size));
        }

        public void DistibuteAnimals()
        {
            wagonList.Clear();
            List<Animal> animalListSorted = sortAnimalsByLargestFirst();
            CheckIfFirstWagonExists();
            CheckForAvailableWagon(animalListSorted);
            
        }

        private void CheckIfFirstWagonExists()
        {
            if (wagonList.Count == 0)
            {
                wagonList.Add(new Wagon());
            }
        }

        //Sort the animal list descending by size, this will allow the algorithm to place the large animals first.
        private List<Animal> sortAnimalsByLargestFirst()
        {
            List<Animal> tempList = new List<Animal>();
            
            var orderBySize = from element in animalListReadOnly orderby element.Size descending orderby element.Diet select element;
            foreach (Animal animal in orderBySize)
            {
                tempList.Add(animal);
            }

            return tempList;
        }

        //Loops through the animals and checks for available wagons, creates a new wagon if a suitable spot doesn't exist.
        private void CheckForAvailableWagon(List<Animal> animalListSorted)
        {
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
