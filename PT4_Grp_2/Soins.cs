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
    public partial class Soins : Modele_listbox
    {
        List<Medic> allProduct;
        DB db;

        Soins_add SA;
        public Soins()
        {
            InitializeComponent();
            this.db = new DB("info-joyeux", "PT4_E2");
            makeListBox();

        }

        private void progressBar2_Click(object sender, EventArgs e)
		{

		}

        private void Soins_Load(object sender, EventArgs e)
        {
            
        }

        /**
         * Function that fills the list of drugs with all the drugs in the database ordered by their name.
         */
        private void makeAllProduct()
        {
            allProduct = new List<Medic>();
            db.openConnection();
            OleDbDataReader reader = db.select("select code_produit from produit Inner join Medicament on Medicament.code_produit = PRODUIT.code_produit " +
                "Inner Join traitement on traitement.code_traitement=Medicament.code_traitement", null);
            while (reader.Read())
            {
                allProduct.Add(new Medic(reader.GetInt32(0), db));
            }
            db.closeConnection();

        }

        /**
       * Function that fills the listbox with all the drugs
       */
        private void makeListBox()
        {
            listMedic.Items.Clear();
            makeAllProduct();
            foreach (Medic p in allProduct)
            {
                listMedic.Items.Add(p.ToString());
            }
            listMedic.Refresh();
        }

        /**
        * Function that launches a form to see the details of a drugs.
        */
        public override void detail_Click(object sender, EventArgs e)
        {
            if (listMedic.Items.Count > 0 && listMedic.SelectedIndex != -1)
            {
                Soins_detail s = new Soins_detail(db, allProduct.ToArray()[listMedic.SelectedIndex]);
                if (s.ShowDialog() == DialogResult.OK)
                {
                    makeListBox();
                }
            }

        }

        /**
         * Function that launches a form to add a drug in the database.
         */
        public override void add_Click(object sender, EventArgs e)
        {
            Soins_add form = new Soins_add();
            if (form.ShowDialog() == DialogResult.OK)
            {
                makeListBox();
            }
        }

        /**
         * Function that launches detail_Click
         */
        private void listbox_DoubleClick(object sender, EventArgs e)
        {
            detail_Click(sender, e);
        }
    }
}

    }
}
