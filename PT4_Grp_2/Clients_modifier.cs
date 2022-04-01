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
	public partial class Clients_modifier : Modele_modifier
	{
		Client client;
		DB DBCon;

		/**
		 * Constructor of the class
		 * 
		 * @Param db the database
		 * @Param c the client to modify
		 */
		public Clients_modifier(DB db, Client c)
		{
			InitializeComponent();
			client = c;
			name.Text = c.Lastname;
			firstname.Text = c.Firstname;
			phone.Text = c.Phone;
			mail.Text = c.Mail;
			DBCon = db;

		}

		/**
		 * Function that tries to update the client. If it can, it sets the DialogResult to ok and close the form. If it can't, it shows an error.
		 * 
		 */
        public override void update_Click(object sender, EventArgs e)
        {
			Client c = new Client();
			Regex rgx = new Regex("^[A-Z]{1}\\D+");
			if (name.Text == null || firstname.Text == null || phone.Text ==null || mail.Text == null)
            {
				MessageBox.Show("Veuillez rentrer tous les champs.");
				return;
			}
			else if (!new Regex("\\S+\\@\\S+\\.\\S+").IsMatch(mail.Text))
			{
				MessageBox.Show("Veuillez renseigner une adresse mail valide (exemple@ex.fr)");
				return;
			}

			else if (!rgx.IsMatch(firstname.Text) || !rgx.IsMatch(name.Text))
			{
				MessageBox.Show("Veuillez renseigner un prénom et nom valide (Commence par une majuscule ");
				return;
			}
			c.Lastname = name.Text;
			c.Firstname = firstname.Text;
			c.Phone = phone.Text;
			c.Mail = mail.Text;
            try
            {
				client.Update(DBCon, c);
				MessageBox.Show("Le client a été modifié avec succés !");
				this.DialogResult = DialogResult.OK;
				Close();
            }
            catch(Exception exc)
            {
				MessageBox.Show("Erreur lors de la modification du client. Verifiez tous les attributs, et si besoin contactez un technicien. Message d'erreur : " + exc);
            }
            
        }

		/**
		 * Function that tries to delete the client. If it can, it sets the DialogResult to yes and close the form. If it can't, it shows an error.
		 */
		public override void Delete_Click(object sender, EventArgs e)
        {
			Modele_delete form = new Modele_delete();
			if (form.ShowDialog() == DialogResult.OK)
			{
				try
				{ 
					client.Delete(DBCon);
					this.DialogResult = DialogResult.Yes;
					MessageBox.Show("Client supprimé avec succés !");

				}
				catch (Exception exc)
				{
					MessageBox.Show("Echec lors de la suppression. Contactez un technicien. Message d'erreur : " + exc);
				}
			}
        }
    }
}
