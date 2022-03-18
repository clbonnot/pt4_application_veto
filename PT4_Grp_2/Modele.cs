using System.Windows.Forms;

namespace PT4_Grp_2
{
	public partial class Modele : Form
	{
		string role;
		string droit;
		public Modele()
		{
			InitializeComponent();
		}

		public void SetRole(string role)
        {
			this.role = role;
        }

		public void SetDroit(string droit)
		{
			this.droit = droit;
		}

		public string GetRole()
        {
			return role;
        }

		public string GetDroit()
        {
			return droit;	
        }

		private void Deconnexion_Click(object sender, System.EventArgs e)
        {
			this.role = null;
			this.droit = null;
        }
    }
}
