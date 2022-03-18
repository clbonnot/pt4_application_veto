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
		string droit;
		string name;
		public Modele()
		{
			InitializeComponent();
			this.RoleName.ForeColor = SystemColors.ControlLightLight;
			this.Person.ForeColor = SystemColors.ControlLightLight;
		}

		public void SetRole(string role)
        {
			this.role = role;
			RoleName.Text = role;
		}

		public void SetDroit(string droit)
		{
			this.droit = droit;
		}

		public void SetName(string name)
		{
			this.name = name;
			Person.Text = name;
		}

		public string GetRole()
        {
			return role;
        }

		public string GetDroit()
        {
			return droit;	
        }

		public string GetName()
        {
			return name;	
        }

		private void Deconnexion_Click(object sender, System.EventArgs e)
        {
			this.role = null;
			this.droit = null;
			this.name=null;
			
			Connexion connexion = new Connexion();
			connexion.StartPosition = FormStartPosition.CenterScreen;
			connexion.ShowDialog();
			this.Close();

		}
    }
}
