using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PT4_Grp_2
{
	public partial class Paniers : Modele
	{
		DB db;
		List<Product> allProducts;
		Dictionary<Product, int> cart;
		decimal tPrice;
		List<Client> allClients;

		/**
		 * Constructor of the class.
		 */
		public Paniers()
		{
			InitializeComponent();
			this.db = new DB("info-joyeux", "PT4_E2");
			cart = new Dictionary<Product, int>();
			makeComboBox();
			tPrice = 0;
			makeListClients();
		}

		/**
		 * Update the total price.
		 */
		private void updateTotal()
        {
			decimal s = 0;
			foreach(KeyValuePair<Product, int> kvp in cart)
            {
				s += kvp.Key.Price * kvp.Value;
            }
			tPrice = s;
			total.Text = s.ToString();
			total.Refresh();
        }

		/**
		 * Function that fill the list and the combobox of clients with all the clients in the database, ordered by their name.
		 */
		private void makeListClients()
        {
			allClients = new List<Client>();
			client.Items.Clear();
			db.openConnection();
			client.Items.Add("Aucun client choisi");
			OleDbDataReader reader = db.select("select code_personne from personne order by nom asc",null);
            while (reader.Read())
            {
				Client c = new Client(reader.GetInt32(0), db);
				allClients.Add(c);
				client.Items.Add(c.ToString());
            }
			db.closeConnection();
			client.SelectedIndex = 0;
			client.Refresh();
        }

	
		/**
		 * Function that fill the list of products with all the products in the database without the ones in the cart.
		 */
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

		/**
		 * Function that fills the combobox with the list of products.
		 */
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

		/**
		 * Function that adds the selected product in the cart if it can. If not, it shows an error.
		 */
        private void add_Click(object sender, EventArgs e)
        {
			if (products.SelectedIndex != -1)
			{
				
				Product p = allProducts.ToArray()[products.SelectedIndex];
				if (p.Quantity != 0)
				{
					cart.Add(p, 1);
					listArticles.Items.Add(p.Name + " | 1");
					makeComboBox();
					updateTotal();
				}
                else
                {
					MessageBox.Show("Ce produit est en rupture de stock ! ");
                }
			}
            else
            {
				MessageBox.Show("Veuillez selectionner un produit à ajouter.");
            }
        }

		/**
		 * Function that modify the quantity of a product selected in the cart.
		 * 
		 * @param int n the number to add to the quantity
		 */
		private void modifyQuantityArticle(int n)
        {
			if(listArticles.SelectedIndex == -1)
            {
				MessageBox.Show("Veuillez selectionner un article.");
				return;
            }
			Product p = cart.Keys.ToArray()[listArticles.SelectedIndex];
			if (cart[p] + n > 0 && cart[p] + n <= p.Quantity)
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

		/**
		 * Function that remove the product selected of the cart.
		 */
		private void removeArticle()
        {
			Product p = cart.Keys.ToArray()[listArticles.SelectedIndex];
			cart.Remove(p);
			listArticles.Items.RemoveAt(listArticles.SelectedIndex);
			listArticles.Refresh();
			makeComboBox();
			updateTotal();
		}

		/**
		 * Function that increase the quantity of the selected product of the cart.
		 */
        private void plus_buy_Click(object sender, EventArgs e)
        {
			modifyQuantityArticle(1);
           
        }

		/**
		 * Function that decrease the quantity of the selected product of the cart.
		 */
        private void minus_buy_Click(object sender, EventArgs e)
        {
			modifyQuantityArticle(-1);
		}

		/**
		* Function that remove the selected product of the cart.
		*/
		private void remove_Click(object sender, EventArgs e)
        {
			if (listArticles.SelectedIndex == -1)
			{
				MessageBox.Show("Veuillez selectionner un article.");
				return;
			}
			removeArticle();
        }

		/**
		 * Function that generate and launch an invoice in a pdf format with all the products in the cart, and push it in the database.
		 */
        private void validate_Click(object sender, EventArgs e)
        {
			Invoice invoice = new Invoice();

			Client selectedClient;
			if (client.SelectedIndex > 0) {
				 selectedClient = allClients.ToArray()[client.SelectedIndex - 1];
				invoice.Client = selectedClient;
			}
            else
            {
				selectedClient = null;
            }

			invoice.Staff = new Staff(this.GetId(), db);
			invoice.Date = DateTime.Now.ToString("yyyy-MM-dd");
			foreach(KeyValuePair<Product, int> kvp in cart)
            {
				invoice.AddSale(kvp.Key, kvp.Value, kvp.Key.Price);
            }

			invoice.generatePdf(db);
			MessageBox.Show("Vente effectuée avec succés ! ");
			clearListArticles();
			invoice.Flush(db);
			Process.Start("facture.pdf");
			




		}

		/**
		 * Function that clear the cart.
		 */
		private void clearListArticles()
        {
			listArticles.Items.Clear();
			cart.Clear();
			listArticles.Refresh();
			tPrice = 0;
			total.Text = "0";
			total.Refresh();
			makeComboBox();


		}

		/**
		 * Function that launch a form to see the details of the product.
		 */
        private void listArticles_DoubleClick(object sender, EventArgs e)
        {
			if (listArticles.SelectedIndex != -1)
			{
				Product p = cart.Keys.ToArray()[listArticles.SelectedIndex];
				Stocks_detail form = new Stocks_detail(db, p);
				if (form.ShowDialog() == DialogResult.OK)
				{
					listArticles.Items[listArticles.SelectedIndex] = p.Name + " | " + cart[p];
				}
			}
		}

		/**
		 * Function that launch clearListArticles()
		 */
        private void clear_Click(object sender, EventArgs e)
        {
			clearListArticles();
			
        }
    }
}
