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
    public partial class Admin : Form
    {

        List<Staff> allStaff;
        public Admin()
        {
            InitializeComponent();
            allStaff = new List<Staff>();
            
            foreach(Staff s in allStaff)
            {
                listStaff.Items.Add(s.lastname + " | " + s.firstname + " | " + s.role);
            }
            if (listStaff.Items.Count > 0)
            {
                listStaff.SelectedIndex = 0;
            }
            listStaff.Refresh();
           
           
        }

        private void makeListStaff(List<Staff> ls)
        {
            //TEMP :
            ls.Add(new Staff());
            //TODO 
        }

        /*
         * Function that launch a form to add a staff in the database. 
         */
        private void add_Click(object sender, EventArgs e)
        {
           
            Admin_add_pers formAdd = new Admin_add_pers();
            formAdd.ShowDialog();

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

		private void disconnect_Click(object sender, EventArgs e)
		{

		}
	}

	//Code temporaire (jusqu'à bd) : 
	public class Staff 
    {
        public string firstname = "Annie";
        public string lastname = "Maux";
        public string role = "Splouch splouch";
        public Staff()
        {

        }
    
    }
}
