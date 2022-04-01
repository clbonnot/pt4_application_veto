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
    public partial class Soins : Modele_listbox
    {
        List<Product> allProduct;
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
            SA = new Soins_add();
            
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
            foreach (Product p in allProduct)
            {
                listbox.Items.Add(p.ToString());
            }
            listbox.Refresh();
        }

    }
}
