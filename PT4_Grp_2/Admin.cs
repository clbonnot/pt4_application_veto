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
    public partial class Admin : Modele
    {

        List<Staff> allStaff;
        public Admin()
        {
            
            InitializeComponent();
            allStaff = new List<Staff>();
            makeListStaff(allStaff);
            foreach(Staff s in allStaff)
            {
                listStaff.Items.Add(s.toString());
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
           
            Modele_add_pers formAdd = new Modele_add_pers();
            formAdd.ShowDialog();

        }




        private void detail_Click(object sender, EventArgs e)
        {
            Admin_detail_pers formDet = new Admin_detail_pers(allStaff.ToArray()[listStaff.SelectedIndex]);
            formDet.ShowDialog();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void Deconnexion_Click(object sender, EventArgs e)
        {
            //Navigation.deconnexion_Click();
        }
    }

 
}
