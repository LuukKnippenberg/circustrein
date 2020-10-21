using System;
using System.Collections.Generic;
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
            Animal.Diet diet;

            if (rbCarnivore.Checked)
            {
                diet = Animal.Diet.Carnivore;
            }
            else
            {
                diet = Animal.Diet.Herbivore;
            }

            train.AddAnimal(tbName.Text, diet, cbSize.Text);
            DisplayAnimalList();
        }

        private void btnFillAnimalsList_Click(object sender, EventArgs e)
        {
            DisplayAnimalList();
        }

        private void DisplayAnimalList()
        {
            lbAnimalList.Items.Clear();
            List<Animal> animalList = train.animalList;

            for (int i = 0; i < animalList.Count; i++)
            {
                Animal currentAnimal = animalList[i];
                lbAnimalList.Items.Add(currentAnimal.name + " - Size: " + currentAnimal.size + " - Diet: " + currentAnimal.diet);
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

            for (int i = 0; i < train.wagonList.Count; i++)
            {
                for (int x = 0; x < train.wagonList[i].animalList.Count; x++)
                {
                    Animal currentAnimal = train.wagonList[i].animalList[x];
                    lbDistributedAnimals.Items.Add(currentAnimal.name + " - Size: " + currentAnimal.size + " - Diet: " + currentAnimal.diet + " - Wagon: " + (i + 1));
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
