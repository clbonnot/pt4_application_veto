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
	public partial class Modele_calendrier : Modele
	{
		public Modele_calendrier()
		{
			InitializeComponent();
            if (this.RoleName.Text.Equals("Vétérinaire"))
            {
                this.control_secretaire1.Hide();
            }
            else
            {
                this.control_veto1.Hide();
            }
        }

        public virtual void add_Click(object sender, EventArgs e)
        {

        }

        public virtual void update_Click(object sender, EventArgs e)
        {

        }

        public virtual void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
