using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Circustrein
{
    class Wagon
    {
        private List<Animal> animalList;
        public ReadOnlyCollection<Animal> animalListReadOnly
        {
            get { return animalList.AsReadOnly(); }
        }
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
                currentContent += (int)animal.Size;
                return true;
            }
            else
            {
                
                return false;
            }            
        }

        private bool CheckForSpace(Animal animal)
        {  
            if (((int)animal.Size + currentContent) <= (maxContent))
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
            for (int i = 0; i < animalList.Count; i++)
            {
                if(animalList[i].Diet == Animal.Diets.Carnivore && (int)animalList[i].Size >= (int)animal.Size)
                {                    
                    return false;
                }

                if(animal.Diet == Animal.Diets.Carnivore && animalList[i].Size <= animal.Size)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
