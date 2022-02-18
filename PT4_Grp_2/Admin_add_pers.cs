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
    public partial class Admin_add_pers : Form
    {
        String current = "";
        public Admin_add_pers()
        {
            InitializeComponent();
            hint();
            
        }

		#region hint
		private void hint()
        {
            //Text Box
            //nom
            
            this.lastName.Leave += new System.EventHandler(this.text_Leave);
            this.lastName.Enter += new System.EventHandler(this.setCurrent_Nom);
            this.lastName.Enter += new System.EventHandler(this.text_Enter);
            //addresse

            this.address.Leave += new System.EventHandler(this.text_Leave);
            this.address.Enter += new System.EventHandler(this.setCurrent_address);
            this.address.Enter += new System.EventHandler(this.text_Enter);
            //prenom

            this.firstname.Leave += new System.EventHandler(this.text_Leave);
            this.firstname.Enter += new System.EventHandler(this.setCurrent_Prenom);
            this.firstname.Enter += new System.EventHandler(this.text_Enter);
            //tel

            this.phone.Leave += new System.EventHandler(this.text_Leave);
            this.phone.Enter += new System.EventHandler(this.setCurrent_phone);
            this.phone.Enter += new System.EventHandler(this.text_Enter);

        }

        private void setCurrent_phone(object sender, EventArgs e)
		{
            current = "Téléphone";
        }

		private void setCurrent_Prenom(object sender, EventArgs e)
		{
            current = "Prénom";
        }

		private void setCurrent_address(object sender, EventArgs e)
		{
            current = "Adresse";
        }

		private void setCurrent_Nom(object sender, EventArgs e)
		{
            current = "Nom";
		}

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

		private void Admin_add_pers_Load(object sender, EventArgs e)
        {

        }
    }
}
