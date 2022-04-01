using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT4_Grp_2
{
	public partial class Clients_add : Modele_add_pers
	{
		DB db;

		/**
		 * Constructor of the class.
		 * 
		 * @Param db the database
		 */
		public Clients_add(DB db )
		{
			InitializeComponent();
			this.db = db;
		}

        /**
         * Function that validate the add of the client in the database, and close the form if it can. If it can't, it shows an error.
         */
		public override void valider_Click(object sender, EventArgs e)
        {
			Client c = new Client();
			Regex rgx = new Regex("^[A-Z]{1}\\D+");
			if (LastName.Text == "" || FirstName.Text == "" || Phone.Text == "" || Address.Text == "")
			{
				MessageBox.Show("Veuillez rentrer tous les champs.");
				return;
			}
			else if (Phone.Text.Length != 10 || !int.TryParse(Phone.Text, out int d) || Phone.Text[0] != '0')
			{
				MessageBox.Show("Veuillez renseigner un numéro de téléphone valide (10 chiffres, commence par 0)");
				return;
			}
			else if (!new Regex("\\S+\\@\\S+\\.\\S+").IsMatch(Address.Text))
			{
				MessageBox.Show("Veuillez renseigner une adresse mail valide (exemple@ex.fr)");
				return;
			}
			
			else if (!new Regex("\\S+\\@\\S+\\.\\S+").IsMatch(Address.Text))
			{
				MessageBox.Show("Veuillez renseigner une adresse mail valide (exemple@ex.fr)");
				return;
			}

			else if (!rgx.IsMatch(FirstName.Text) || !rgx.IsMatch(LastName.Text))
			{
				MessageBox.Show("Veuillez renseigner un prénom et nom valide (Commence par une majuscule ");
				return;
			}
			c.Lastname = LastName.Text;
			c.Firstname = FirstName.Text;
			c.Phone = Phone.Text;
			c.Mail = Address.Text;
            try
            {
				c.Flush(db);
				MessageBox.Show("Client ajouté avec succés ! ");
				this.DialogResult = DialogResult.OK;
				Close();
            }
			catch(Exception exc)
            {
				MessageBox.Show("Erreur lors de l'ajout du client. Verifiez que tous les champs sont valides, et contactez un technicien si besoin. Message d'erreur : " + exc);
            }
		}
    }
}
