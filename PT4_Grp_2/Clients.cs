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
    public partial class Clients : Modele_listbox
    {
        DB DBCon;
        List<Client> allClients;
        public Clients()
        {
            InitializeComponent();
            this.DBCon = new DB("info-joyeux", "PT4_E2");
            makeListBox();
        }

        private List<Client> makeListClients()
        {
            List<Client> lc = new List<Client>();
            DBCon.openConnection();
            OleDbDataReader reader = DBCon.select("Select Code_Personne from personne", null);
            while (reader.Read())
            {
                lc.Add(new Client(reader.GetInt32(0), DBCon));
            }
            DBCon.closeConnection();
            return lc;
        }
        private void makeListBox()
        {
            listbox.Items.Clear();
            allClients = makeListClients();
            foreach(Client c in allClients)
            {
                listbox.Items.Add(c.ToString());
            }
            listbox.Refresh();
        }

        public override void detail_Click(object sender, EventArgs e)
        {
            Clients_details form = new Clients_details(allClients.ToArray()[listbox.SelectedIndex], DBCon);
            if(form.ShowDialog() == DialogResult.OK)
            {
                makeListBox();
            }
        }

        private void listbox_DoubleClick(object sender, EventArgs e)
        {
            detail_Click(sender, e);
        }

        public override void add_Click(object sender, EventArgs e)
        {
            Clients_add form = new Clients_add(DBCon);
            if(form.ShowDialog() == DialogResult.OK)
            {
                makeListBox();
            }
        }
    }
}
