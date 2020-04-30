using System;
using System.Collections.Generic;

namespace Circustrein
{
    public class Animal
    {
        public Animal(string name, string diet, int size)
        {
            Name = name;
            Diet = diet;
            Size = size;
        }

        public string Name { get; set; }
        public string Diet { get; set; }
        public int Size { get; set; }
    }
}
