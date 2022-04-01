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
    public partial class Admin_detail_pers : Modele
    {

        Staff staff;
        DB DBCon;

        /**
         * Constructor of the class
         * 
         * @param s the staff looked
         * @param d the database
         */
        public Admin_detail_pers(Staff s, DB d)
        {
            InitializeComponent();
            role.Text = s.Role;
            lastnameV.Text = s.Lastname;
            firstnameV.Text = s.Firstname;
            date.Text = s.Start_date;
            endDate.Text = s.End_date;
            salary.Text = s.Salary.ToString();
            phone.Text = s.Phone;
            address.Text = s.Mail;
            Identify.Text = s.Identify;
            staff = s;
            DBCon = d;
            Refresh();
        }

        /**
         * Function that launch a new Form that allow the user to modify the staff looked.  
         */
        private void modif_pers_Click(object sender, EventArgs e)
        {
            Admin_modifier_pers amp;
            Boolean b = this.GetIdStaff() == staff.IdStaff;
            if (b)
            {
                amp = new Admin_modifier_pers(staff, DBCon, true);
            }
            else
            {
                amp = new Admin_modifier_pers(staff, DBCon, false);
              
            }
            DialogResult dr = amp.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (b)
                {
                    this.SetName(staff.Lastname);
                    this.SetRole(staff.Role);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if(dr == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
