using System;
using System.Collections.Generic;

namespace Circustrein
{
    class Wagon
    {
        public List<Animal> animalList { get; private set; }
        private int currentContent;
        private int maxContent = 10;

        public Wagon()
        {
            animalList = new List<Animal>();
        }

        public bool AddAnimal(Animal animal)
        {
            if(CheckForSpace(animal) && CheckSafety(animal))
            {
                animalList.Add(animal);
                currentContent = currentContent + animal.Size;
                return true;
            }
            else
            {
                return false;
            }            
        }

        private bool CheckForSpace(Animal animal)
        {  
            if ((animal.Size + currentContent) <= (maxContent))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private bool CheckSafety(Animal animal)
        {
            bool safe = true;

            for (int i = 0; i < animalList.Count; i++)
            {
                if(animalList[i].Diet.ToLower() == "carnivore" && animalList[i].Size >= animal.Size)
                {
                    safe = false;
                }

                if(animal.Diet.ToLower() == "carnivore" && animalList[i].Size <= animal.Size)
                {
                    safe = false;
                }
            }

            if (safe)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
