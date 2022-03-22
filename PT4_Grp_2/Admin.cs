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

        public Admin()
        {
            
            InitializeComponent();
            
            
           
        }

        private void makeListStaff()
        {
            
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
            Admin_detail_pers formDet = new Admin_detail_pers();
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
