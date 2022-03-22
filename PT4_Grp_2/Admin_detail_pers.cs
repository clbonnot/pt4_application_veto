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
        public Admin_detail_pers()
        {
            InitializeComponent();
            roleV.Text = s.Role;
            lastnameV.Text = s.Lastname;
            firstnameV.Text = s.Firstname;
            date.Text = s.Start_date;
            salary.Text = s.Salary.ToString();
            phone.Text = s.Phone;
            address.Text = s.Mail;


            Refresh();
        }

        private void Admin_detail_pers_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
