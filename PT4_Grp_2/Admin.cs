using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT4_Grp_2
{
    public partial class Admin : Modele_listbox
    {
        DB DBCon;
        List<Staff> allStaff;
        /**
         * Constructor of the class
         */
        public Admin()
        {
            
            InitializeComponent();
            this.DBCon = new DB("info-joyeux", "PT4_E2");
            allStaff = makeListStaff();
            
            foreach(Staff s in allStaff)
            {
                listbox.Items.Add(s.toString());
            }
            if (listbox.Items.Count > 0)
            {
                listbox.SelectedIndex = 0;
            }
            listbox.Refresh();
            
           
        }

        /**
         * Function that generate a list of all staff that are in the database
         * 
         * return that list
         */
        private List<Staff> makeListStaff()
        {
            DBCon.openConnection();
            List<Staff> ls = new List<Staff>();
            OleDbDataReader r = DBCon.select("Select code_personnel from personnel;",null);
            
            while (r.Read())
            {
                ls.Add(new Staff(r.GetInt32(0),DBCon));
            }
            DBCon.closeConnection();
            return ls;
        }

        /*
         * Function that launch a form to add a staff in the database. 
         */
        public override void add_Click(object sender, EventArgs e)
        {
            
            Modele_add_pers formAdd = new Admin_add_pers(DBCon);
            formAdd.ShowDialog();

        }



        /*
         * Function that launch a form to see the detail of the staff selected.
         */
        public override void detail_Click(object sender, EventArgs e)
        {
            Admin_detail_pers formDet = new Admin_detail_pers(allStaff.ToArray()[listbox.SelectedIndex]);
            formDet.ShowDialog();
        }

       
    }

 
}
