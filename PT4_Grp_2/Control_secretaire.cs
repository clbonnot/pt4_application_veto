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
			cal.StartPosition = FormStartPosition.CenterScreen;
			cal.FormClosed += (s, args) => ((Form)this.TopLevelControl).Close();
			cal.ShowDialog();


		}

		private void stock_Click(object sender, EventArgs e)
		{
			((Form)this.TopLevelControl).Hide();
			Stocks stocks = new Stocks();
			stocks.StartPosition = FormStartPosition.CenterScreen;
			stocks.FormClosed += (s, args) => ((Form)this.TopLevelControl).Close();
			stocks.ShowDialog();

		}

		private void shop_Click(object sender, EventArgs e)
		{
			((Form)this.TopLevelControl).Hide();
			Paniers panier = new Paniers();
			panier.StartPosition = FormStartPosition.CenterScreen;
			panier.FormClosed += (s, args) => ((Form)this.TopLevelControl).Close();
			panier.ShowDialog();

		}

		private void client_Click(object sender, EventArgs e)
		{
			((Form)this.TopLevelControl).Hide();
			Clients clients = new Clients();
			clients.StartPosition = FormStartPosition.CenterScreen;
			clients.FormClosed += (s, args) => ((Form)this.TopLevelControl).Close();
			clients.ShowDialog();

		}

		private void stats_Click(object sender, EventArgs e)
		{
			((Form)this.TopLevelControl).Hide();
			Statistiques stats = new Statistiques();
			stats.StartPosition = FormStartPosition.CenterScreen;
			stats.FormClosed += (s, args) => ((Form)this.TopLevelControl).Close();
			stats.ShowDialog();

		}
	}
}
