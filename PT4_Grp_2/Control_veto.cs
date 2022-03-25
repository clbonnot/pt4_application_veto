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
			Clients clients = new Clients();
			clients.StartPosition = FormStartPosition.CenterScreen;
		}

		private void maladie_Click(object sender, EventArgs e)
		{
			Maladies maladies = new Maladies();
			maladies.StartPosition = FormStartPosition.CenterScreen;

		}

		private void soin_Click(object sender, EventArgs e)
		{
			Soins soins = new Soins();
			soins.StartPosition = FormStartPosition.CenterScreen;
		}

		private void Calendrier_Click(object sender, EventArgs e)
		{
			Calendrier_rdv cal = new Calendrier_rdv();
			cal.StartPosition = FormStartPosition.CenterScreen;
		}
	}
}
