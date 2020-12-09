using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein;

namespace CircustreinTest
{
    [TestClass]
    public class TrainTest
    {
        [TestMethod]
        public void AddAnimal_ExpectedSizeEqualsFive_True()
        {
            // Arrange
            string name = "test";
            Animal.Diets diet = Animal.Diets.Herbivore;
            Animal.Sizes size = Animal.Sizes.Large;
            int expectedSize = 5;
            Train train = new Train();

            // Act
            train.AddAnimal(name, diet, size);

            //Assert
            int actual = (int)train.animalListReadOnly[0].Size;
            Assert.AreEqual(expectedSize, actual);
        }

        [TestMethod]
        public void AddAnimal_ExpectedAmountOfWagonsDoesNotEqualSeven_True()
        {
            // Arrange
            string name = "test";
            Animal.Diets diet = Animal.Diets.Herbivore;
            Animal.Sizes size = Animal.Sizes.Large;
            int expectedSize = 7;
            Train train = new Train();

            // Act
            train.AddAnimal(name, diet, size);

            //Assert
            int actual = (int)train.animalListReadOnly[0].Size;
            Assert.AreNotEqual(expectedSize, actual);
        }

        [TestMethod]
        public void AddAnimalAndDistributeAnimals_ExpectedAmountOfWagonsEqualsFive_True()
        {
            //Arrange
            Train train = new Train();
            string name = "test";
            Animal.Diets diet = Animal.Diets.Herbivore;
            Animal.Sizes size1 = Animal.Sizes.Small;
            Animal.Sizes size2 = Animal.Sizes.Medium;
            Animal.Sizes size3 = Animal.Sizes.Large;
            int expectedSize = 5;
            
            //Act
            train.AddAnimal(name, diet, size1);
            train.AddAnimal(name, diet, size2);
            train.AddAnimal(name, diet, size3);
            train.DistibuteAnimals();

            //Assert
            int actual = (int)train.wagonListReadOnly[0].animalListReadOnly[0].Size;
            Assert.AreEqual(expectedSize, actual);
        }

        [TestMethod]
        public void DistributeAnimals_ExpectedAmountOfWagonsEqualsTwoBecauseOfSafety_True()
        {
            //Arrange
            Train train = new Train();
            string name = "test";
            Animal.Diets diet = Animal.Diets.Herbivore;
            Animal.Diets diet2 = Animal.Diets.Carnivore;
            Animal.Sizes size1 = Animal.Sizes.Small;
            Animal.Sizes size2 = Animal.Sizes.Medium;
            Animal.Sizes size3 = Animal.Sizes.Large;
            int expectedAmountOfWagons = 2;

            //Act
            train.AddAnimal(name, diet, size1);
            train.AddAnimal(name, diet2, size2);
            train.AddAnimal(name, diet, size3);
            train.DistibuteAnimals();

            //Assert
            int actual = train.wagonListReadOnly.Count;
            Assert.AreEqual(expectedAmountOfWagons, actual);
        }

        [TestMethod]
        public void DistributeAnimals_ExpectedAmountOfWagonsEqualsFour_True()
        {
            //Arrange
            Train train = new Train();
            string name = "test";
            Animal.Diets diet = Animal.Diets.Herbivore;
            Animal.Sizes size = Animal.Sizes.Small;
            int expectedAmountOfWagons = 4;

            //Act
            for (int i = 0; i < 35; i++)
            {
                train.AddAnimal(name, diet, size);
            }
            train.DistibuteAnimals();

            //Assert
            int actual = train.wagonListReadOnly.Count;
            Assert.AreEqual(expectedAmountOfWagons, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException),
            "Expected amount of wagons does not equal the actual amount of wagons!")]
        public void DistributeAnimals_ExpectedAmountOfWagonsEqualsSixty_ExceptionThrown()
        {
            //Arrange
            Train train = new Train();
            string name = "test";
            Animal.Diets diet = Animal.Diets.Herbivore;
            Animal.Sizes size = Animal.Sizes.Small;
            int expectedAmountOfWagons = 60;

            //Act
            for (int i = 0; i < 35; i++)
            {
                train.AddAnimal(name, diet, size);
            }
            train.DistibuteAnimals();

            //Assert
            int actual = train.wagonListReadOnly.Count;
            Assert.AreEqual(expectedAmountOfWagons, actual);
        }
    }
}
