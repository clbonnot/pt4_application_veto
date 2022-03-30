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
    public partial class Stocks : Modele_listbox
    {
        List<Product> allProduct;
        DB db;

        /**
         * Constructor of the class
         */
        public Stocks()
        {
            InitializeComponent();
            this.db = new DB("info-joyeux", "PT4_E2");
            makeListBox();
        }

        /**
         * Function that fills the list of products with all the product in the database ordered by their name.
         */
        private void makeAllProduct()
        {
            allProduct = new List<Product>();
            db.openConnection();
            OleDbDataReader reader = db.select("select code_produit from produit order by nom asc", null);
            while (reader.Read())
            {
                allProduct.Add(new Product(reader.GetInt32(0), db));
            }
            db.closeConnection();

        }

        /**
       * Function that fills the listbox with all the product 
       */
        private void makeListBox()
        {
            listbox.Items.Clear();
            makeAllProduct();
            foreach(Product p in allProduct)
            {
                listbox.Items.Add(p.ToString());
            }
            listbox.Refresh(); 
        }

        
        /**
         * Function that launches a form to see the details of a product.
         */
        public override void detail_Click(object sender, EventArgs e)
        {
            if (listbox.Items.Count > 0 && listbox.SelectedIndex != -1)
            {
                Stocks_detail s = new Stocks_detail(db, allProduct.ToArray()[listbox.SelectedIndex]);
                if (s.ShowDialog() == DialogResult.OK)
                {
                    makeListBox();
                }
            }
         
        }
        
        /**
         * Function that launches a form to add a product in the database.
         */
        public override void add_Click(object sender, EventArgs e)
        {
            Stocks_add form = new Stocks_add(db);
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
