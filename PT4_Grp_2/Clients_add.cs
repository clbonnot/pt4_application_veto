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
			if (LastName.Text == null || FirstName.Text == null || Phone.Text == null || Address.Text == null)
			{
				MessageBox.Show("Veuillez rentrer tous les champs.");
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
