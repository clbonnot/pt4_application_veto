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
			clients.FormClosed += (s, args) => ((Form)this.TopLevelControl).Close();
			clients.ShowDialog();
		}

		private void maladie_Click(object sender, EventArgs e)
		{
			((Form)this.TopLevelControl).Hide();
			Maladies maladies = new Maladies();
			maladies.StartPosition = FormStartPosition.CenterScreen;
			maladies.FormClosed += (s, args) => ((Form)this.TopLevelControl).Close();
			maladies.ShowDialog();
		}

		private void soin_Click(object sender, EventArgs e)
		{
			((Form)this.TopLevelControl).Hide();
			Soins soins = new Soins();
			soins.StartPosition = FormStartPosition.CenterScreen;
			soins.FormClosed += (s, args) => ((Form)this.TopLevelControl).Close();
			soins.ShowDialog();
		}

		private void Calendrier_Click(object sender, EventArgs e)
		{
			((Form)this.TopLevelControl).Hide();
			Calendrier_rdv cal = new Calendrier_rdv();
			cal.StartPosition = FormStartPosition.CenterScreen;
			cal.FormClosed += (s, args) => ((Form)this.TopLevelControl).Close();
			cal.ShowDialog();
		}
	}
}
