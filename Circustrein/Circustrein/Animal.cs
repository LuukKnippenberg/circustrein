using System;
using System.Collections.Generic;

namespace Circustrein
{
    class Animal
    {

        public enum Diet { Carnivore, Herbivore };

        public Animal(string _name, Diet _diet, int _size)
        {
            name = _name;
            size = _size;
            diet = _diet;
        }

        public string name { get; set; }
        public Diet diet { get; set; }
        public int size { get; set; }
    }
}
