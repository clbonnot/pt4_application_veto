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
	public partial class Modele_delete : Form
	{
		public Modele_delete()
		{
			InitializeComponent();
		}

        private void ok_Click(object sender, EventArgs e)
        {
			this.DialogResult = DialogResult.OK;
			Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
			Close();
        }
    }
}
