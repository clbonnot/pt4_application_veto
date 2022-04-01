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
	public partial class Control_veto : UserControl
	{
		public Control_veto()
		{
			InitializeComponent();
		}



		private void client_Click(object sender, EventArgs e)
		{
			((Form)this.TopLevelControl).Hide();
			Clients clients = new Clients();
			clients.StartPosition = FormStartPosition.CenterScreen;
			clients.SetId(((Modele)this.TopLevelControl).GetIdStaff());
			clients.SetName(((Modele)this.TopLevelControl).GetName());
			clients.SetRights(((Modele)this.TopLevelControl).GetAdmin());
			//Console.WriteLine(((Modele)this.TopLevelControl).GetAdmin());
			clients.SetRole(((Modele)this.TopLevelControl).GetRole());
			clients.FormClosed += (s, args) => ((Form)this.TopLevelControl).Close();
			clients.ShowDialog();
		}

		private void maladie_Click(object sender, EventArgs e)
		{
			((Form)this.TopLevelControl).Hide();
			Maladies maladies = new Maladies();
			maladies.StartPosition = FormStartPosition.CenterScreen;
			maladies.SetId(((Modele)this.TopLevelControl).GetIdStaff());
			maladies.SetName(((Modele)this.TopLevelControl).GetName());
			maladies.SetRights(((Modele)this.TopLevelControl).GetAdmin());
			//Console.WriteLine(((Modele)this.TopLevelControl).GetAdmin());
			maladies.SetRole(((Modele)this.TopLevelControl).GetRole());
			maladies.FormClosed += (s, args) => ((Form)this.TopLevelControl).Close();
			maladies.ShowDialog();
		}

		private void soin_Click(object sender, EventArgs e)
		{
			((Form)this.TopLevelControl).Hide();
			Soins soins = new Soins();
			soins.StartPosition = FormStartPosition.CenterScreen;
			soins.SetId(((Modele)this.TopLevelControl).GetIdStaff());
			soins.SetName(((Modele)this.TopLevelControl).GetName());
			soins.SetRights(((Modele)this.TopLevelControl).GetAdmin());
			//Console.WriteLine(((Modele)this.TopLevelControl).GetAdmin());
			soins.SetRole(((Modele)this.TopLevelControl).GetRole());
			soins.FormClosed += (s, args) => ((Form)this.TopLevelControl).Close();
			soins.ShowDialog();
		}

		private void Calendrier_Click(object sender, EventArgs e)
		{
			((Form)this.TopLevelControl).Hide();
			Calendrier_rdv cal = new Calendrier_rdv();
			cal.StartPosition = FormStartPosition.CenterScreen;
			cal.SetId(((Modele)this.TopLevelControl).GetIdStaff());
			cal.SetName(((Modele)this.TopLevelControl).GetName());
			cal.SetRights(((Modele)this.TopLevelControl).GetAdmin());
			//Console.WriteLine(((Modele)this.TopLevelControl).GetAdmin());
			cal.SetRole(((Modele)this.TopLevelControl).GetRole());
			cal.FormClosed += (s, args) => ((Form)this.TopLevelControl).Close();
			cal.ShowDialog();
		}

        private void stock_Click(object sender, EventArgs e)
        {
			((Form)this.TopLevelControl).Hide();
			Stocks stocks = new Stocks();
			stocks.StartPosition = FormStartPosition.CenterScreen;
			stocks.SetId(((Modele)this.TopLevelControl).GetIdStaff());
			stocks.SetName(((Modele)this.TopLevelControl).GetName());
			stocks.SetRights(((Modele)this.TopLevelControl).GetAdmin());
			stocks.SetRole(((Modele)this.TopLevelControl).GetRole());
			stocks.FormClosed += (s, args) => ((Form)this.TopLevelControl).Close();
			stocks.ShowDialog();

		}

		private void panier_Click(object sender, EventArgs e)
        {
			((Form)this.TopLevelControl).Hide();
			Paniers panier = new Paniers();
			panier.StartPosition = FormStartPosition.CenterScreen;
			panier.SetId(((Modele)this.TopLevelControl).GetIdStaff());
			panier.SetName(((Modele)this.TopLevelControl).GetName());
			panier.SetRights(((Modele)this.TopLevelControl).GetAdmin());
			panier.SetRole(((Modele)this.TopLevelControl).GetRole());
			panier.FormClosed += (s, args) => ((Form)this.TopLevelControl).Close();
			panier.ShowDialog();
		}

        private void stats_Click(object sender, EventArgs e)
        {
			((Form)this.TopLevelControl).Hide();
			Statistiques stats = new Statistiques();
			stats.StartPosition = FormStartPosition.CenterScreen;
			stats.SetId(((Modele)this.TopLevelControl).GetIdStaff());
			stats.SetName(((Modele)this.TopLevelControl).GetName());
			stats.SetRights(((Modele)this.TopLevelControl).GetAdmin());
			stats.SetRole(((Modele)this.TopLevelControl).GetRole());
			stats.FormClosed += (s, args) => ((Form)this.TopLevelControl).Close();
			stats.ShowDialog();
		}

        private void admin_Click(object sender, EventArgs e)
        {
			((Form)this.TopLevelControl).Hide();
			Admin admin = new Admin();
			admin.StartPosition = FormStartPosition.CenterScreen;
			admin.SetId(((Modele)this.TopLevelControl).GetIdStaff());
			admin.SetName(((Modele)this.TopLevelControl).GetName());
			admin.SetRights(((Modele)this.TopLevelControl).GetAdmin());
			admin.SetRole(((Modele)this.TopLevelControl).GetRole());
			admin.FormClosed += (s, args) => ((Form)this.TopLevelControl).Close();
			admin.ShowDialog();

		}
	}
}
