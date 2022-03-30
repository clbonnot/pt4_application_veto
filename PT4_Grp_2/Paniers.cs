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
	public partial class Paniers : Modele
	{
		DB db;
		List<Product> allProducts;
		Dictionary<Product, int> cart;

		public Paniers()
		{
			InitializeComponent();
			this.db = new DB("info-joyeux", "PT4_E2");
			cart = new Dictionary<Product, int>();
			makeComboBox();
		}

		private void updateTotal()
        {
			decimal s = 0;
			foreach(KeyValuePair<Product, int> kvp in cart)
            {
				s += kvp.Key.Price * kvp.Value;
            }
			total.Text = s.ToString();
			total.Refresh();
        }

		private void makeListProducts()
        {
			allProducts = new List<Product>();
			db.openConnection();
			String cmd = "select code_produit from produit ";
			Product[] p = cart.Keys.ToArray();
			List<string> args = new List<string>();
			for(int i = 0; i < p.Length; i++)
            {
				if(i == 0)
                {
					cmd += " where ";
                }
				cmd += "code_produit != ? ";
				if(i != p.Length - 1)
                {
					cmd += " and ";
                }
				args.Add(p[i].Id.ToString());
            }
			cmd += "order by nom asc";
			
			OleDbDataReader reader = db.select(cmd, args.ToArray());
            while (reader.Read())
            {
				allProducts.Add(new Product(reader.GetInt32(0), db));
            }
			db.closeConnection();
        }

		private void makeComboBox()
        {
			products.Items.Clear();
			products.Text = " ";
			makeListProducts();
			foreach(Product p in allProducts)
            {
				products.Items.Add(p.Name);
            }
			products.Refresh();
        }

	
        private void add_Click(object sender, EventArgs e)
        {
			if (products.SelectedIndex != -1)
			{
				Product p = allProducts.ToArray()[products.SelectedIndex];
				cart.Add(p, 1);
				listArticles.Items.Add(p.Name + " | 1"); 
				makeComboBox();
				updateTotal();
			}
            else
            {
				MessageBox.Show("Veuillez selectionner un produit à ajouter.");
            }
        }

		private void modifyQuantityArticle(int n)
        {
			if(listArticles.SelectedIndex == -1)
            {
				MessageBox.Show("Veuillez selectionner un article.");
				return;
            }
			Product p = cart.Keys.ToArray()[listArticles.SelectedIndex];
			if (cart[p] + n > 0 && cart[p] + n < p.Quantity)
			{
				cart[p] += n;
				listArticles.Items[listArticles.SelectedIndex] = p.Name + " | " + cart[p];			
				listArticles.Refresh();
				updateTotal();
			}
			else if(cart[p] + n == 0)
            {
				removeArticle();
				
			}
            else
            {
				MessageBox.Show("Ce produit n'est pas présent plus de fois dans la base de données");
            }
			
        }

		private void removeArticle()
        {
			Product p = cart.Keys.ToArray()[listArticles.SelectedIndex];
			cart.Remove(p);
			listArticles.Items.RemoveAt(listArticles.SelectedIndex);
			listArticles.Refresh();
			makeComboBox();
			updateTotal();
		}
        private void plus_buy_Click(object sender, EventArgs e)
        {
			modifyQuantityArticle(1);
           
        }

        private void minus_buy_Click(object sender, EventArgs e)
        {
			modifyQuantityArticle(-1);
		}

        private void remove_Click(object sender, EventArgs e)
        {
			if (listArticles.SelectedIndex == -1)
			{
				MessageBox.Show("Veuillez selectionner un article.");
				return;
			}
			removeArticle();
        }
    }
}
