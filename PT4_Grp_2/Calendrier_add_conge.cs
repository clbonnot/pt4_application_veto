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
	public partial class Calendrier_add_conge : Form
	{
		public Calendrier_add_conge()
		{
			InitializeComponent();
		}

		private void dateEnd_ValueChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void nbJours_Click(object sender, EventArgs e)
		{

		}

        private void add_Click(object sender, EventArgs e)
        {
			Console.WriteLine(dateStart.Text);
			Console.WriteLine(dateEnd.Text);
		}

        private void button1_Click(object sender, EventArgs e)
        {
			this.Close();
        }

		private string convertMonthToNumber(string month)
        {
            switch (month)
            {
				case "janvier":
					return "01";
				case "février":
					return "02";
				case "mars":
					return "03";
				case "avril":
					return "04";
				case "mai":
					return "05";
				case "juin":
					return "06";
				case "juilet":
					return "07";
				case "août":
					return "08";
				case "septembre":
					return "09";
				case "octobre":
					return "10";
				case "novembre":
					return "11";
				case "décembre":
					return "12";
				default:
					break;
			}
			return month;
        }
    }
}
