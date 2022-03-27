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
	public partial class Calendrier_rdv : Modele_calendrier
	{

		public Calendrier_rdv()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void add_Click(object sender, EventArgs e)
        {
			Calendrier_add_rdv ajouter = new Calendrier_add_rdv();
			ajouter.ShowDialog();
		}
	}
}
