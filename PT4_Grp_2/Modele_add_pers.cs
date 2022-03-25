using System;
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

        public string Current { get => current; set => current = value; }

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
            this.LastName.Leave += new System.EventHandler(this.text_Leave);
            this.LastName.Enter += new System.EventHandler(this.setCurrent_Nom);
            this.LastName.Enter += new System.EventHandler(this.text_Enter);
            //address
            this.Address.Leave += new System.EventHandler(this.text_Leave);
            this.Address.Enter += new System.EventHandler(this.setCurrent_address);
            this.Address.Enter += new System.EventHandler(this.text_Enter);
            //firstname
            this.FirstName.Leave += new System.EventHandler(this.text_Leave);
            this.FirstName.Enter += new System.EventHandler(this.setCurrent_Prenom);
            this.FirstName.Enter += new System.EventHandler(this.text_Enter);
            //phone
            this.Phone.Leave += new System.EventHandler(this.text_Leave);
            this.Phone.Enter += new System.EventHandler(this.setCurrent_phone);
            this.Phone.Enter += new System.EventHandler(this.text_Enter);

        }


        /**
        * Initiate the "current" string
        */
        private void setCurrent_phone(object sender, EventArgs e)
		{
            Current = "Téléphone";
        }

        /**
        * Initiate the "current" string
        */
        private void setCurrent_Prenom(object sender, EventArgs e)
		{
            Current = "Prénom";
        }

        /**
        * Initiate the "current" string
        */
        private void setCurrent_address(object sender, EventArgs e)
		{
            Current = "Adresse";
        }

        /**
        * Initiate the "current" string
        */
        private void setCurrent_Nom(object sender, EventArgs e)
		{
            Current = "Nom";
		}

        /**
          * Make disappear the text from the textBox on click
          */
        private void text_Enter(object sender, EventArgs e)
		{

            if (LastName.Text.Equals("Nom") && Current.Equals("Nom"))
            {
                LastName.Clear();
                LastName.ForeColor = SystemColors.WindowText;
            }
            if (Address.Text.Equals("Adresse") && Current.Equals("Adresse"))
            {
                Address.Clear();
                Address.ForeColor = SystemColors.WindowText;
            }
            if (Phone.Text.Equals("Téléphone") && Current.Equals("Téléphone") )
            {
                Phone.Clear();
                Phone.ForeColor = SystemColors.WindowText;
            }
            if (FirstName.Text.Equals("Prénom") && Current.Equals("Prénom") )
            {
                FirstName.Clear();
                FirstName.ForeColor = SystemColors.WindowText;
            }
        }

        /**
          * Put a text as which looks like a hint in leave 
          */
        private void text_Leave(object sender, EventArgs e)
		{
            if (LastName.Text.Length == 0)
            {
                LastName.Text = "Nom";
                LastName.ForeColor = SystemColors.GrayText;
            }
            if (Address.Text.Length == 0)
            {
                Address.Text = "Adresse";
                Address.ForeColor = SystemColors.GrayText;
            }
            if (Phone.Text.Length == 0)
            {
                Phone.Text = "Téléphone";
                Phone.ForeColor = SystemColors.GrayText;
            }
            if (FirstName.Text.Length == 0)
            {
                FirstName.Text = "Prénom";
                FirstName.ForeColor = SystemColors.GrayText;
            }
        }
        #endregion

     
        private void annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        public virtual void valider_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
