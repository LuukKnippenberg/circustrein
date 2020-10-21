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
                currentContent = currentContent + animal.size;
                return true;
            }
            else
            {
                return false;
            }            
        }

        private bool CheckForSpace(Animal animal)
        {  
            if ((animal.size + currentContent) <= (maxContent))
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
            //bool safe = true;

            for (int i = 0; i < animalList.Count; i++)
            {
                if(animalList[i].diet.ToString() == "carnivore" && animalList[i].size >= animal.size)
                {
                    //safe = false;
                    return false;
                }

                if(animal.diet.ToString() == "carnivore" && animalList[i].size <= animal.size)
                {
                    //safe = false;
                    return false;
                }
            }

            return true;

            /*
            if (safe)
            {
                return true;
            }
            else
            {
                return false;
            }
            */
        }
    }
}
