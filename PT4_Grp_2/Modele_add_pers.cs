﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT4_Grp_2
{
    public partial class Modele_add_pers : Modele
    {
        String current = "";
        public Modele_add_pers()
        {
            InitializeComponent();
            hint();
            
        }

        #region hint

        /**
         * Put text from textbox as a hint
         */
        private void hint()
        {
            //Text Box
            //Name
            this.lastName.Leave += new System.EventHandler(this.text_Leave);
            this.lastName.Enter += new System.EventHandler(this.setCurrent_Nom);
            this.lastName.Enter += new System.EventHandler(this.text_Enter);
            //address
            this.address.Leave += new System.EventHandler(this.text_Leave);
            this.address.Enter += new System.EventHandler(this.setCurrent_address);
            this.address.Enter += new System.EventHandler(this.text_Enter);
            //firstname
            this.firstname.Leave += new System.EventHandler(this.text_Leave);
            this.firstname.Enter += new System.EventHandler(this.setCurrent_Prenom);
            this.firstname.Enter += new System.EventHandler(this.text_Enter);
            //phone
            this.phone.Leave += new System.EventHandler(this.text_Leave);
            this.phone.Enter += new System.EventHandler(this.setCurrent_phone);
            this.phone.Enter += new System.EventHandler(this.text_Enter);

        }


        /**
        * Initiate the "current" string
        */
        private void setCurrent_phone(object sender, EventArgs e)
		{
            current = "Téléphone";
        }

        /**
        * Initiate the "current" string
        */
        private void setCurrent_Prenom(object sender, EventArgs e)
		{
            current = "Prénom";
        }

        /**
        * Initiate the "current" string
        */
        private void setCurrent_address(object sender, EventArgs e)
		{
            current = "Adresse";
        }

        /**
        * Initiate the "current" string
        */
        private void setCurrent_Nom(object sender, EventArgs e)
		{
            current = "Nom";
		}

        /**
          * Make disappear the text from the textBox on click
          */
        private void text_Enter(object sender, EventArgs e)
		{

            if (lastName.Text.Equals("Nom") && current.Equals("Nom"))
            {
                lastName.Clear();
                lastName.ForeColor = SystemColors.WindowText;
            }
            if (address.Text.Equals("Adresse") && current.Equals("Adresse"))
            {
                address.Clear();
                address.ForeColor = SystemColors.WindowText;
            }
            if (phone.Text.Equals("Téléphone") && current.Equals("Téléphone") )
            {
                phone.Clear();
                phone.ForeColor = SystemColors.WindowText;
            }
            if (firstname.Text.Equals("Prénom") && current.Equals("Prénom") )
            {
                firstname.Clear();
                firstname.ForeColor = SystemColors.WindowText;
            }
        }

        /**
          * Put a text as which looks like a hint in leave 
          */
        private void text_Leave(object sender, EventArgs e)
		{
            if (lastName.Text.Length == 0)
            {
                lastName.Text = "Nom";
                lastName.ForeColor = SystemColors.GrayText;
            }
            if (address.Text.Length == 0)
            {
                address.Text = "Adresse";
                address.ForeColor = SystemColors.GrayText;
            }
            if (phone.Text.Length == 0)
            {
                phone.Text = "Téléphone";
                phone.ForeColor = SystemColors.GrayText;
            }
            if (firstname.Text.Length == 0)
            {
                firstname.Text = "Prénom";
                firstname.ForeColor = SystemColors.GrayText;
            }
        }
        #endregion

        /**
         * Makes sure every data is valid
         */
        private void valider_Click(object sender, EventArgs e)
        {

            if (password.Text == "aaaaaa" || lastName.Text == "Nom" || phone.Text == "Téléphone" || id.Text == "Identifiant")
            {
                MessageBox.Show("Veuillez renseigner tous les attributs obligatoires.");
            }
            else if (phone.Text.Length != 10)
            {
                MessageBox.Show("Veuillez renseigner un numéro de téléphone valide");
            }
            else
            {
                //ajouterPersonnel();
                MessageBox.Show("Personnel ajouté avec succès !");
                Close();
            }
        }

    }
}
