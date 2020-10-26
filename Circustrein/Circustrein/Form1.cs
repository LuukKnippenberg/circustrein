using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Circustrein;

namespace Circustrein
{
    public partial class Form1 : Form
    {
        private Train train = new Train();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            Animal.Diets diet;

            if (rbCarnivore.Checked)
            {
                diet = Animal.Diets.Carnivore;
            }
            else
            {
                diet = Animal.Diets.Herbivore;
            }

            Animal.Sizes size;

            //Converts size to number for storage
            switch (cbSize.Text.ToLower())
            {
                case "small":
                    size = Animal.Sizes.Small;
                    break;
                case "medium":
                    size = Animal.Sizes.Medium;
                    break;
                default:
                    size = Animal.Sizes.Large;
                    break;
            }

            train.AddAnimal(tbName.Text, diet, size);
            DisplayAnimalList();
        }

        private void btnFillAnimalsList_Click(object sender, EventArgs e)
        {
            DisplayAnimalList();
        }

        private void DisplayAnimalList()
        {
            lbAnimalList.Items.Clear();
            List<Animal> animalList = new List<Animal>(train.animalListReadOnly);

            for (int i = 0; i < animalList.Count; i++)
            {
                Animal currentAnimal = animalList[i];
                lbAnimalList.Items.Add(currentAnimal.Name + " - Size: " + currentAnimal.Size + " - Diet: " + currentAnimal.Diet);
            }
        }

        //Function that sends the distribution request
        private void btnDistributeAnimals_Click(object sender, EventArgs e)
        {
            train.DistibuteAnimals();
            DisplayDistribution();
        }

        private void DisplayDistribution()
        {
            lbDistributedAnimals.Items.Clear();

            for (int i = 0; i < train.wagonListReadOnly.Count; i++)
            {
                for (int x = 0; x < train.wagonListReadOnly[i].animalListReadOnly.Count; x++)
                {
                    Animal currentAnimal = train.wagonListReadOnly[i].animalListReadOnly[x];
                    lbDistributedAnimals.Items.Add(currentAnimal.Name + " - Size: " + currentAnimal.Size + " - Diet: " + currentAnimal.Diet + " - Wagon: " + (i + 1));
                }
            }
        }

        private void btnClearLists_Click(object sender, EventArgs e)
        {
            train.ClearLists();
            lbDistributedAnimals.Items.Clear();
            lbAnimalList.Items.Clear();
        }
    }
}
