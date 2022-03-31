
namespace PT4_Grp_2
{
    partial class Clients_Animal
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
            this.notes = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.name_medic = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.addSpecies = new System.Windows.Forms.Button();
            this.addRace = new System.Windows.Forms.Button();
            this.races = new System.Windows.Forms.ComboBox();
            this.species = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sexe = new System.Windows.Forms.ComboBox();
            this.age = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(26, 448);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(333, 87);
            this.notes.TabIndex = 86;
            this.notes.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Honeydew;
            this.progressBar1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.progressBar1.Location = new System.Drawing.Point(23, 541);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(336, 3);
            this.progressBar1.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 84;
            this.label7.Text = "Date de naissance";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(88, 400);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 83;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 81;
            this.label4.Text = "Âge : ";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(77, 110);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 78;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.Honeydew;
            this.progressBar2.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.progressBar2.Location = new System.Drawing.Point(23, 58);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(336, 3);
            this.progressBar2.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 76;
            this.label2.Text = "Race";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "Informations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 74;
            this.label1.Text = "Espèce";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(23, 428);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(45, 17);
            this.description.TabIndex = 73;
            this.description.Text = "Notes";
            // 
            // name_medic
            // 
            this.name_medic.AutoSize = true;
            this.name_medic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_medic.Location = new System.Drawing.Point(72, 80);
            this.name_medic.Name = "name_medic";
            this.name_medic.Size = new System.Drawing.Size(59, 26);
            this.name_medic.TabIndex = 72;
            this.name_medic.Text = "Nom";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 87;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addSpecies
            // 
            this.addSpecies.Location = new System.Drawing.Point(303, 224);
            this.addSpecies.Name = "addSpecies";
            this.addSpecies.Size = new System.Drawing.Size(75, 23);
            this.addSpecies.TabIndex = 88;
            this.addSpecies.Text = "autre";
            this.addSpecies.UseVisualStyleBackColor = true;
            this.addSpecies.Click += new System.EventHandler(this.addSpecies_Click);
            // 
            // addRace
            // 
            this.addRace.Location = new System.Drawing.Point(303, 287);
            this.addRace.Name = "addRace";
            this.addRace.Size = new System.Drawing.Size(75, 23);
            this.addRace.TabIndex = 89;
            this.addRace.Text = "autre";
            this.addRace.UseVisualStyleBackColor = true;
            this.addRace.Click += new System.EventHandler(this.addRace_Click);
            // 
            // races
            // 
            this.races.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.races.FormattingEnabled = true;
            this.races.Location = new System.Drawing.Point(88, 289);
            this.races.Name = "races";
            this.races.Size = new System.Drawing.Size(200, 21);
            this.races.TabIndex = 90;
            // 
            // species
            // 
            this.species.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.species.FormattingEnabled = true;
            this.species.Location = new System.Drawing.Point(88, 226);
            this.species.Name = "species";
            this.species.Size = new System.Drawing.Size(200, 21);
            this.species.TabIndex = 91;
            this.species.SelectedIndexChanged += new System.EventHandler(this.species_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 93;
            this.label3.Text = "Poids : ";
            // 
            // mass
            // 
            this.mass.Location = new System.Drawing.Point(146, 353);
            this.mass.Name = "mass";
            this.mass.Size = new System.Drawing.Size(41, 20);
            this.mass.TabIndex = 94;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 95;
            this.label6.Text = "kg";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(85, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 96;
            this.label8.Text = "Sexe";
            // 
            // sexe
            // 
            this.sexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexe.FormattingEnabled = true;
            this.sexe.Items.AddRange(new object[] {
            "m",
            "f"});
            this.sexe.Location = new System.Drawing.Point(88, 182);
            this.sexe.Name = "sexe";
            this.sexe.Size = new System.Drawing.Size(200, 21);
            this.sexe.TabIndex = 97;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(136, 317);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(13, 13);
            this.age.TabIndex = 98;
            this.age.Text = "0";
            // 
            // Clients_Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(383, 620);
            this.Controls.Add(this.age);
            this.Controls.Add(this.sexe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.species);
            this.Controls.Add(this.races);
            this.Controls.Add(this.addRace);
            this.Controls.Add(this.addSpecies);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.name_medic);
            this.Name = "Clients_Animal";
            this.Text = "Clients_Animal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox notes;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker date;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox name;
        public System.Windows.Forms.ProgressBar progressBar2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label description;
        public System.Windows.Forms.Label name_medic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addSpecies;
        private System.Windows.Forms.Button addRace;
        public System.Windows.Forms.ComboBox races;
        public System.Windows.Forms.ComboBox species;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox mass;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox sexe;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label age;
    }
}