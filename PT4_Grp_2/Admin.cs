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
            makeListBox();


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
            OleDbDataReader r = DBCon.select("Select code_personnel from personnel inner join personne on personnel.code_personne = personne.code_personne order by nom asc;", null);

            while (r.Read())
            {
                ls.Add(new Staff(r.GetInt32(0), DBCon));
            }
            DBCon.closeConnection();
            return ls;
        }

        /**
         * Function that fill the listbox of the form with the list of all the staff of the database. 
         */
        private void makeListBox()
        {
            
            
         
            foreach (Staff s in allStaff)
            {
                listbox.Items.Add(s.toString());
            }
            if (listbox.Items.Count > 0)
            {
                listbox.SelectedIndex = 0;
            }
            
            listbox.Refresh();

        }
        /*
         * Function that launch a form to add a staff in the database. 
         */
        public override void add_Click(object sender, EventArgs e)
        {

            Modele_add_pers formAdd = new Admin_add_pers(DBCon);
           
            formAdd.SetName(this.GetName());

            formAdd.SetRole(this.GetRole());
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                listbox.Items.Clear();
                allStaff = makeListStaff();
                this.makeListBox();
            }
        }



        /*
         * Function that launch a form to see the detail of the staff selected.
         */
        public override void detail_Click(object sender, EventArgs e)
        {
            if (listbox.Items.Count > 0)
            {
                Admin_detail_pers formDet = new Admin_detail_pers(allStaff.ToArray()[listbox.SelectedIndex], DBCon);
                formDet.SetIdStaff(this.GetIdStaff());
                formDet.SetName(this.GetName());
                
                formDet.SetRole(this.GetRole());
                if (formDet.ShowDialog() == DialogResult.OK)
                {
                    listbox.Items.Clear();
                    allStaff = makeListStaff();
                    makeListBox();
                }
            }

        }

        /**
         * Function that launch the detail_Click function.
         */
        private void listbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            detail_Click(sender, e);
        }

    }


}
