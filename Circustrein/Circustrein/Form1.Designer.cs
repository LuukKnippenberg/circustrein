namespace Circustrein
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbAddAnimal = new System.Windows.Forms.GroupBox();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblDiet = new System.Windows.Forms.Label();
            this.rbCarnivore = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.rbHerbivore = new System.Windows.Forms.RadioButton();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbAnimalList = new System.Windows.Forms.GroupBox();
            this.lbAnimalList = new System.Windows.Forms.ListBox();
            this.gbDistributedAnimals = new System.Windows.Forms.GroupBox();
            this.lbDistributedAnimals = new System.Windows.Forms.ListBox();
            this.btnDistributeAnimals = new System.Windows.Forms.Button();
            this.btnClearLists = new System.Windows.Forms.Button();
            this.gbAddAnimal.SuspendLayout();
            this.gbAnimalList.SuspendLayout();
            this.gbDistributedAnimals.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddAnimal
            // 
            this.gbAddAnimal.Controls.Add(this.btnAddAnimal);
            this.gbAddAnimal.Controls.Add(this.cbSize);
            this.gbAddAnimal.Controls.Add(this.lblSize);
            this.gbAddAnimal.Controls.Add(this.lblDiet);
            this.gbAddAnimal.Controls.Add(this.rbCarnivore);
            this.gbAddAnimal.Controls.Add(this.lblName);
            this.gbAddAnimal.Controls.Add(this.rbHerbivore);
            this.gbAddAnimal.Controls.Add(this.tbName);
            this.gbAddAnimal.Location = new System.Drawing.Point(12, 12);
            this.gbAddAnimal.Name = "gbAddAnimal";
            this.gbAddAnimal.Size = new System.Drawing.Size(200, 426);
            this.gbAddAnimal.TabIndex = 0;
            this.gbAddAnimal.TabStop = false;
            this.gbAddAnimal.Text = "Add Animal";
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(58, 121);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(116, 23);
            this.btnAddAnimal.TabIndex = 2;
            this.btnAddAnimal.Text = "Add Animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // cbSize
            // 
            this.cbSize.AutoCompleteCustomSource.AddRange(new string[] {
            "Small",
            "Medium",
            "Large"});
            this.cbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cbSize.Location = new System.Drawing.Point(58, 94);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(121, 21);
            this.cbSize.TabIndex = 6;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(6, 91);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(30, 13);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "Size:";
            // 
            // lblDiet
            // 
            this.lblDiet.AutoSize = true;
            this.lblDiet.Location = new System.Drawing.Point(6, 48);
            this.lblDiet.Name = "lblDiet";
            this.lblDiet.Size = new System.Drawing.Size(29, 13);
            this.lblDiet.TabIndex = 4;
            this.lblDiet.Text = "Diet:";
            // 
            // rbCarnivore
            // 
            this.rbCarnivore.AutoSize = true;
            this.rbCarnivore.Location = new System.Drawing.Point(58, 71);
            this.rbCarnivore.Name = "rbCarnivore";
            this.rbCarnivore.Size = new System.Drawing.Size(70, 17);
            this.rbCarnivore.TabIndex = 3;
            this.rbCarnivore.TabStop = true;
            this.rbCarnivore.Text = "Carnivore";
            this.rbCarnivore.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // rbHerbivore
            // 
            this.rbHerbivore.AutoSize = true;
            this.rbHerbivore.Location = new System.Drawing.Point(58, 48);
            this.rbHerbivore.Name = "rbHerbivore";
            this.rbHerbivore.Size = new System.Drawing.Size(71, 17);
            this.rbHerbivore.TabIndex = 1;
            this.rbHerbivore.TabStop = true;
            this.rbHerbivore.Text = "Herbivore";
            this.rbHerbivore.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(58, 19);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 0;
            // 
            // gbAnimalList
            // 
            this.gbAnimalList.Controls.Add(this.btnClearLists);
            this.gbAnimalList.Controls.Add(this.lbAnimalList);
            this.gbAnimalList.Location = new System.Drawing.Point(218, 12);
            this.gbAnimalList.Name = "gbAnimalList";
            this.gbAnimalList.Size = new System.Drawing.Size(200, 426);
            this.gbAnimalList.TabIndex = 1;
            this.gbAnimalList.TabStop = false;
            this.gbAnimalList.Text = "Animal List";
            // 
            // lbAnimalList
            // 
            this.lbAnimalList.FormattingEnabled = true;
            this.lbAnimalList.Location = new System.Drawing.Point(6, 48);
            this.lbAnimalList.Name = "lbAnimalList";
            this.lbAnimalList.Size = new System.Drawing.Size(188, 368);
            this.lbAnimalList.TabIndex = 0;
            // 
            // gbDistributedAnimals
            // 
            this.gbDistributedAnimals.Controls.Add(this.lbDistributedAnimals);
            this.gbDistributedAnimals.Controls.Add(this.btnDistributeAnimals);
            this.gbDistributedAnimals.Location = new System.Drawing.Point(424, 12);
            this.gbDistributedAnimals.Name = "gbDistributedAnimals";
            this.gbDistributedAnimals.Size = new System.Drawing.Size(364, 426);
            this.gbDistributedAnimals.TabIndex = 1;
            this.gbDistributedAnimals.TabStop = false;
            this.gbDistributedAnimals.Text = "Distribute Animals";
            // 
            // lbDistributedAnimals
            // 
            this.lbDistributedAnimals.FormattingEnabled = true;
            this.lbDistributedAnimals.Location = new System.Drawing.Point(6, 48);
            this.lbDistributedAnimals.Name = "lbDistributedAnimals";
            this.lbDistributedAnimals.Size = new System.Drawing.Size(352, 368);
            this.lbDistributedAnimals.TabIndex = 1;
            // 
            // btnDistributeAnimals
            // 
            this.btnDistributeAnimals.Location = new System.Drawing.Point(6, 19);
            this.btnDistributeAnimals.Name = "btnDistributeAnimals";
            this.btnDistributeAnimals.Size = new System.Drawing.Size(116, 23);
            this.btnDistributeAnimals.TabIndex = 0;
            this.btnDistributeAnimals.Text = "Distribute Animals";
            this.btnDistributeAnimals.UseVisualStyleBackColor = true;
            this.btnDistributeAnimals.Click += new System.EventHandler(this.btnDistributeAnimals_Click);
            // 
            // btnClearLists
            // 
            this.btnClearLists.Location = new System.Drawing.Point(6, 20);
            this.btnClearLists.Name = "btnClearLists";
            this.btnClearLists.Size = new System.Drawing.Size(116, 23);
            this.btnClearLists.TabIndex = 7;
            this.btnClearLists.Text = "Remove All Animals";
            this.btnClearLists.UseVisualStyleBackColor = true;
            this.btnClearLists.Click += new System.EventHandler(this.btnClearLists_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbDistributedAnimals);
            this.Controls.Add(this.gbAnimalList);
            this.Controls.Add(this.gbAddAnimal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbAddAnimal.ResumeLayout(false);
            this.gbAddAnimal.PerformLayout();
            this.gbAnimalList.ResumeLayout(false);
            this.gbDistributedAnimals.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddAnimal;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton rbHerbivore;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox gbAnimalList;
        private System.Windows.Forms.ListBox lbAnimalList;
        private System.Windows.Forms.GroupBox gbDistributedAnimals;
        private System.Windows.Forms.ListBox lbDistributedAnimals;
        private System.Windows.Forms.Button btnDistributeAnimals;
        private System.Windows.Forms.RadioButton rbCarnivore;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblDiet;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Button btnClearLists;
    }
}

