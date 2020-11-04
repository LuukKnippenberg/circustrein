using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein;

namespace CircustreinTest
{
    [TestClass]
    public class WagonTest
    {
        [TestMethod]
        public void CheckWagonForSafety()
        {
            //Arrange
            Wagon wagon = new Wagon();
            string name = "test";
            Animal.Diets diet = Animal.Diets.Carnivore;
            Animal.Sizes size = Animal.Sizes.Medium;

            Animal animal = new Animal(name, diet, size);

            //Act
            wagon.AddAnimal(animal);

            //Assert
            Assert.IsFalse(wagon.AddAnimal(animal));
            
        }
    }
}
