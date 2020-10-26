using System;
using System.Collections.Generic;

namespace Circustrein
{
    partial class Animal
    {
        //Size Enum
        public Animal(string _name, Diets _diet, Sizes _size)
        {
            Name = _name;
            Size = _size;
            Diet = _diet;
        }

        public string Name { get; private set; }
        public Diets Diet { get; private set; }
        public Sizes Size { get; private set; }
    }
}
