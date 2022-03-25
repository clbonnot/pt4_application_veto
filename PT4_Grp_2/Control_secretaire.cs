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
			Calendrier_rdv cal = new Calendrier_rdv();
			cal.StartPosition = FormStartPosition.CenterScreen;
		}

		private void stock_Click(object sender, EventArgs e)
		{
			Stocks stocks = new Stocks();
			stocks.StartPosition = FormStartPosition.CenterScreen;
		}

		private void shop_Click(object sender, EventArgs e)
		{
			Paniers panier = new Paniers();
			panier.StartPosition = FormStartPosition.CenterScreen;
		}

		private void client_Click(object sender, EventArgs e)
		{
			Clients clients = new Clients();
			clients.StartPosition = FormStartPosition.CenterScreen;
		}

		private void stats_Click(object sender, EventArgs e)
		{
			Statistiques stats = new Statistiques();
			stats.StartPosition = FormStartPosition.CenterScreen;
		}
	}
}
