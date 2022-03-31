using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT4_Grp_2
{
	public partial class Modele : Form
	{
		public string roleUser;
		public int id;
		public Boolean admin;
		public string nameUser;
		/*
		 * Create a new model for all the other forms
		*/
		public Modele()
		{
			InitializeComponent();
			this.RoleName.ForeColor = SystemColors.ControlLightLight;
			this.Person.ForeColor = SystemColors.ControlLightLight;
		}

		/**
		 * Set the db id of the current user
		 */
		public void SetId(int id)
        {
			this.id = id;
        }
		/*
		 * Set the role of the current user
		 */
		public void SetRole(string role)
        {
			this.roleUser = role;
			RoleName.Text = role;
		}
		/*
		 * Set the rights of the current user
		 */
		public void SetRights(string right)
		{
			if(right.Equals("administrateur"))
            {
				this.admin = true;	
            }
			else
            {
				this.admin = false;	
            }
		}
		/*
		 * Set the name of the current user
		 */
		public void SetName(string name)
		{
			this.nameUser = name;
			Person.Text = name;
		}

		public int GetId()
        {
			return id;
        }
		/*
		 * Get the role of the current user
		 */
		public string GetRole()
        {
			
			return roleUser;
        }
		/*
		 * Get the rights of the current user
		 */
		public Boolean GetAdmin()
        {
			return admin;
        }
		/*
		 * Get the name of the current user
		 */
		public string GetName()
        {
			return nameUser;	
        }
		/*
		 * Disconnect the user and start the connection page
		 */
		private void Deconnexion_Click(object sender, System.EventArgs e)
        {
			
			this.roleUser = null;
			this.admin = false;
			this.nameUser=null;
			this.Hide();

			Connexion connexion = new Connexion();
			
			connexion.StartPosition = FormStartPosition.CenterScreen;
			connexion.FormClosed += (s, args) => this.Close();
			

			connexion.Show();
		}
    }
} 
