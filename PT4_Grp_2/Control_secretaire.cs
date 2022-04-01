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
	public partial class Control_secretaire : UserControl
	{
		public Control_secretaire()
		{
			InitializeComponent();
		}

		private void Calendrier_Click(object sender, EventArgs e)
		{
			((Form)this.TopLevelControl).Hide();
			Calendrier_rdv cal = new Calendrier_rdv();
			cal.SetId(((Modele)this.TopLevelControl).GetId());
			cal.SetIdStaff(((Modele)this.TopLevelControl).GetIdStaff());
			cal.SetName(((Modele)this.TopLevelControl).GetName());
			cal.SetRights(((Modele)this.TopLevelControl).GetAdmin());
			cal.SetRole(((Modele)this.TopLevelControl).GetRole());
			cal.StartPosition = FormStartPosition.CenterScreen;
			cal.FormClosed += (s, args) => ((Form)this.TopLevelControl).Close();
			cal.ShowDialog();

		}

		private void stock_Click(object sender, EventArgs e)
		{
			((Form)this.TopLevelControl).Hide();
			Stocks stocks = new Stocks();
			stocks.StartPosition = FormStartPosition.CenterScreen;
			stocks.SetId(((Modele)this.TopLevelControl).GetId());
			stocks.SetIdStaff(((Modele)this.TopLevelControl).GetIdStaff());
			stocks.SetName(((Modele)this.TopLevelControl).GetName());
			stocks.SetRights(((Modele)this.TopLevelControl).GetAdmin());
			stocks.SetRole(((Modele)this.TopLevelControl).GetRole());
			stocks.FormClosed += (s, args) => ((Form)this.TopLevelControl).Close();
			stocks.ShowDialog();

		}

		private void shop_Click(object sender, EventArgs e)
		{
			((Form)this.TopLevelControl).Hide();
			Paniers panier = new Paniers();
			panier.StartPosition = FormStartPosition.CenterScreen;
			panier.SetId(((Modele)this.TopLevelControl).GetId());
			panier.SetIdStaff(((Modele)this.TopLevelControl).GetIdStaff());
			panier.SetName(((Modele)this.TopLevelControl).GetName());
			panier.SetRights(((Modele)this.TopLevelControl).GetAdmin());
			panier.SetRole(((Modele)this.TopLevelControl).GetRole());
			panier.FormClosed += (s, args) => ((Form)this.TopLevelControl).Close();
			panier.ShowDialog();

		}

		private void client_Click(object sender, EventArgs e)
		{
			((Form)this.TopLevelControl).Hide();
			Clients clients = new Clients();
			clients.StartPosition = FormStartPosition.CenterScreen;
			clients.SetId(((Modele)this.TopLevelControl).GetId());
			clients.SetIdStaff(((Modele)this.TopLevelControl).GetIdStaff());
			clients.SetName(((Modele)this.TopLevelControl).GetName());
			clients.SetRights(((Modele)this.TopLevelControl).GetAdmin());
			clients.SetRole(((Modele)this.TopLevelControl).GetRole());
			clients.FormClosed += (s, args) => ((Form)this.TopLevelControl).Close();
			clients.ShowDialog();

		}

		private void stats_Click(object sender, EventArgs e)
		{
			((Form)this.TopLevelControl).Hide();
			Statistiques stats = new Statistiques();
			stats.StartPosition = FormStartPosition.CenterScreen;
			stats.SetId(((Modele)this.TopLevelControl).GetId());
			stats.SetIdStaff(((Modele)this.TopLevelControl).GetIdStaff());
			stats.SetName(((Modele)this.TopLevelControl).GetName());
			stats.SetRights(((Modele)this.TopLevelControl).GetAdmin());
			stats.SetRole(((Modele)this.TopLevelControl).GetRole());
			stats.FormClosed += (s, args) => ((Form)this.TopLevelControl).Close();
			stats.ShowDialog();

		}
	}
}
