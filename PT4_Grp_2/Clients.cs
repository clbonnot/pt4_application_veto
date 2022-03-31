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
        
        /**
         * Constructor of the class.
         */
        public Clients()
        {
            InitializeComponent();
            this.DBCon = new DB("info-joyeux", "PT4_E2");
            makeListBox();
        }

        /**
         * Function that create a list of all the clients in the database.
         * 
         * @Return List<Client> that list
         */
        private List<Client> makeListClients()
        {
            List<Client> lc = new List<Client>();
            DBCon.openConnection();
            OleDbDataReader reader = DBCon.select("Select Code_Personne from personne order by nom asc", null);
            while (reader.Read())
            {
                lc.Add(new Client(reader.GetInt32(0), DBCon));
            }
            DBCon.closeConnection();
            return lc;
        }

        /**
         * Function that generate the listBox of the form
         * 
         */
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

        /**
         * Function that launch a form to see all the details of the client.
         */
        public override void detail_Click(object sender, EventArgs e)
        {
            if (listbox.Items.Count > 0)
            {
                Clients_details form = new Clients_details(allClients.ToArray()[listbox.SelectedIndex], DBCon);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    makeListBox();
                }
            }
        }

        /**
         * Function that launch the detail_Click function.
         */
        private void listbox_DoubleClick(object sender, EventArgs e)
        {
            detail_Click(sender, e);
        }

        /**
         * Function that launch a form to add a client in the database.
         */
        public override void add_Click(object sender, EventArgs e)
        {
            Clients_add form = new Clients_add(DBCon);
            if(form.ShowDialog() == DialogResult.OK)
            {
                makeListBox();
            }
        }

        /**
         * Function that launch a form to ask the user if he wants to delete the client selected in the database.
         */
        private void Delete_Click(object sender, EventArgs e)
        {
            if (listbox.SelectedIndex != -1)
            {
                Client c = allClients.ToArray()[listbox.SelectedIndex];
                if (this.GetId() != c.Id)
                {
                    Modele_delete form = new Modele_delete();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            c.Delete(DBCon);
                            MessageBox.Show("Client supprimé avec succés !");

                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show("Echec lors de la suppression. Contactez un technicien. Message d'erreur : " + exc);
                        }
                    }
                    makeListBox();
                }
                else
                {
                    MessageBox.Show("Vous ne pouvez pas vous supprimer vous même ! ");
                }
            }
        }
    }
}
