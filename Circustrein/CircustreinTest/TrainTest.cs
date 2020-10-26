using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein;

namespace CircustreinTest
{
    [TestClass]
    public class TrainTest
    {
        [TestMethod]
        public void AddNewAnimal()
        {
            // Arrange
            string name = "test";
            string diet = "Herbivore";
            string size = "Large";
            int expectedSize = 5;
            Train train = new Train();

            // Act
            train.AddAnimal(name, diet, size);

            //Assert
            int actual = train.animalListReadOnly[0].Size;
            Assert.AreEqual(expectedSize, actual);
        }

        [TestMethod]
        public void CreateAnimalsAndDistribute()
        {
            //Arrange
            Train train = new Train();
            string name = "test";
            string diet = "Herbivore";
            string size1 = "Small";
            string size2 = "Medium";
            string size3 = "Large";
            int expectedSize = 5;
            
            //Act
            train.AddAnimal(name, diet, size1);
            train.AddAnimal(name, diet, size2);
            train.AddAnimal(name, diet, size3);
            train.DistibuteAnimals();

            //Assert
            int actual = train.wagonListReadOnly[0].animalList[0].Size;
            Assert.AreEqual(expectedSize, actual);
        }

        [TestMethod]
        public void DistributeWithCarnivore()
        {
            //Arrange
            Train train = new Train();
            string name = "test";
            string diet = "herbivore";
            string diet2 = "carnivore";
            string size1 = "Small";
            string size2 = "Medium";
            string size3 = "Large";
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
        public void WagonMaxContentCheck()
        {
            //Arrange
            Train train = new Train();
            string name = "test";
            string diet = "herbivore";
            string size = "small";
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
    }
}
