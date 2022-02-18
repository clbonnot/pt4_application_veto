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
        public Admin_add_pers()
        {
            InitializeComponent();
        }

        /**
         * 
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
                ajouterPersonnel();
                MessageBox.Show("Personnel ajouté avec succès !");
                Close();
            }
        }

        private void ajouterPersonnel()
        {
            //TODO !!
        }
   
    }
}
