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
	public partial class Calendrier_conge : Modele_calendrier
	{
		public Calendrier_conge()
		{
			InitializeComponent();
		}

        public override void add_Click(object sender, EventArgs e)
        {
			Calendrier_add_conge ajout = new Calendrier_add_conge();
        }

	}
}
