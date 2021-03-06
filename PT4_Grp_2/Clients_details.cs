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
	public partial class Clients_details : Modele
	{
		Client client;
		DB db;

		/**
		 * Constructor of the class
		 * 
		 * @Param c the client seeing
		 * @Param d the database
		 */
		public Clients_details(Client c, DB d)
		{
			InitializeComponent();
			lastnameV.Text = c.Lastname;
			firstnameV.Text = c.Firstname;
			phone.Text = c.Phone;
			address.Text = c.Mail;
			client = c;
			db = d;
			
			makeListBox();

			Refresh();
			
		}
	
		/**
		 * Function that fills the listbox of animals with all the client's animal
		 */
		private void makeListBox()
        {
			listAnim.Items.Clear();
			foreach(Animal a in client.Animals)
            {
				listAnim.Items.Add(a.ToString(db));
            }
			listAnim.Refresh();
        }

		/**
		 * Function that closes the form
		 */
        private void back_page_Click(object sender, EventArgs e)
        {
			Close();
        }

		/**
		 * Function that launch a form to update the selected animal.
		 */
        private void updateAnim_Click(object sender, EventArgs e)
        {
			if (listAnim.SelectedIndex != -1)
			{
				Clients_Animal_Modifier form = new Clients_Animal_Modifier(db, client.Animals.ToArray()[listAnim.SelectedIndex]);
				if (form.ShowDialog() == DialogResult.OK)
				{
					makeListBox();

				}
			}
        }

		/**
		 * Function that launches a form to add an animal in the database.
		 */
        private void addAnim_Click(object sender, EventArgs e)
        {
			Clients_Animal_Add form = new Clients_Animal_Add(db, client);
			if(form.ShowDialog() == DialogResult.OK)
            {
				makeListBox();
            }
        }

		/**
		 * Function that launches a form to update the client in the database.
		 */
        private void update_Click(object sender, EventArgs e)
        {
			Clients_modifier form = new Clients_modifier(db, client);
			DialogResult d = form.ShowDialog();
			if (d == DialogResult.OK)
            {
				this.Refresh();
            }
			else if(d == DialogResult.Yes)
            {
				this.DialogResult = DialogResult.OK;
				this.Close();
            }
			
        }


		/**
		 * Function that launches the updateAnim_Click function
		 */
        private void listAnim_DoubleClick(object sender, EventArgs e)
        {
			updateAnim_Click(sender, e);
		}
    }
}
