using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT4_Grp_2
{
    public partial class Logs : Modele_listbox
    {

        List<Invoice> allInvoices;
        DB db;
        public Logs()
        {
            InitializeComponent();
            this.db = new DB("info-joyeux", "PT4_E2");
            makeListBox();
        }

        /**
         * Function that generate the listbox and fill the list of invoices with all the invoices in the database
         */
        private void makeListBox()
        {
            allInvoices = new List<Invoice>();
            listbox.Items.Clear();
            db.openConnection();
            OleDbDataReader reader = db.select("select code_facture from facture", null);
            while (reader.Read())
            {
                Invoice i = new Invoice(reader.GetInt32(0), db);
                allInvoices.Add(i);
                listbox.Items.Add(i.ToString());
            }
            listbox.Refresh();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(listbox.SelectedIndex == -1) {
                MessageBox.Show("Selectionnez une facture à supprimer");
                return;
            }
            allInvoices.ToArray()[listbox.SelectedIndex].Delete(db);
            makeListBox();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            if (listbox.SelectedIndex == -1)
            {
                MessageBox.Show("Selectionnez une facture à générer");
                return;
            }
            allInvoices.ToArray()[listbox.SelectedIndex].generatePdf(db);
            Process.Start("facture.pdf");
        }
    }
}
