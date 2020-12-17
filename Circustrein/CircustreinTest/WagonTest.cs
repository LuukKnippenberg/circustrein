using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein;

namespace CircustreinTest
{
    [TestClass]
    public class WagonTest
    {

        //Improve
        [TestMethod]
        public void AddAnimal_AddCorrectAnimalToWagon_True()
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
            Assert.IsTrue(wagon.animalListReadOnly[0] == animal);
        }


        [TestMethod]
        [ExpectedException(typeof(AssertFailedException),
            "Expected amount of animals does not equal the actual amount of animals in the wagon!")]
        public void AddAnimal_AddTooManyAnimalsToWagon_ExceptionThrow()
        {
            //Arrange
            Wagon wagon = new Wagon();
            string name = "test";
            Animal.Diets diet = Animal.Diets.Carnivore;
            Animal.Sizes size = Animal.Sizes.Medium;

            Animal animal = new Animal(name, diet, size);

            int expectedAmountOfAnimalsInWagon = 25;

            //Act
            for(int i = 0; i < 25; i++){
                wagon.AddAnimal(animal);
            }

            //Assert
            Assert.AreEqual(wagon.animalListReadOnly.Count, expectedAmountOfAnimalsInWagon);
        }

    }
}
