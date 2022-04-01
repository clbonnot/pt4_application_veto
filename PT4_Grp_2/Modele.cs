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
		string role;
		Boolean admin;
		string name;
		/*
		 * Create a new model for all the other forms
		*/
		public Modele(Form f)
		{
			InitializeComponent();
			this.RoleName.ForeColor = SystemColors.ControlLightLight;
			this.Person.ForeColor = SystemColors.ControlLightLight;
			f.Close();
		}
		/*
		 * Set the role of the current user
		 */
		public void SetRole(string role)
        {
			this.role = role;
			RoleName.Text = role;
		}
		/*
		 * Set the rights of the current user
		 */
		public void SetRights(string right)
		{
			if(right.Equals("adimistrateur"))
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
			this.name = name;
			Person.Text = name;
		}
		/*
		 * Get the role of the current user
		 */
		public string GetRole()
        {
			return role;
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
			return name;	
        }

		public void CloseForm(Form f)
        {
			f.Close();
        }
		/*
		 * Disconnect the user and start the connection page
		 */
		private void Deconnexion_Click(object sender, System.EventArgs e)
        {
			this.role = null;
			this.admin = false;
			this.name=null;
			
			Connexion connexion = new Connexion();
			connexion.StartPosition = FormStartPosition.CenterScreen;
			connexion.ShowDialog();
			this.Close();

		}
    }
}
