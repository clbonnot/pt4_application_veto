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
	public partial class Stocks_Fournisseur_add : Form
	{

		DB db;
		Product product;
		List<Supplier> allSuppliers;

		/**
		 * Constructor of the class.
		 */
		public Stocks_Fournisseur_add(DB db, Product p)
		{
			InitializeComponent();
			this.db = db;
			this.product = p;
			makeComboBox();
		}

		/**
		 * Function that fill the list of suppliers with all the suppliers that are not already suppliers of the product.
		 */
		private void makeAllSuppliers()
        {
			allSuppliers = new List<Supplier>();
			db.openConnection();
			String[] arg = { product.Id.ToString() };
            OleDbDataReader reader = db.select("select fournisseur.CODE_FOURNISSEUR from Fournisseur " +
				"left outer join FournisseurProduit ON Fournisseur.CODE_FOURNISSEUR = FournisseurProduit.CODE_FOURNISSEUR " +
				"left outer join Produit ON FournisseurProduit.CODE_PRODUIT = PRODUIT.CODE_PRODUIT " +
				"group by Fournisseur.CODE_FOURNISSEUR " +
				" except " +
				"select code_fournisseur from FournisseurProduit where CODE_PRODUIT = ?", arg);
			while (reader.Read())
			{
				allSuppliers.Add(new Supplier(reader.GetInt32(0), db));
			}
			db.closeConnection();
		}

		/**
		 * Function that fill the combobox with our list of suppliers.
		 */
		private void makeComboBox()
        {
			comboBox.Items.Clear();
			makeAllSuppliers();
			
			foreach(Supplier s in allSuppliers)
            {
				comboBox.Items.Add(s.Name);
            }
			Refresh();
			
		
        }

		/**
		 * Function that close the form
		 */
        private void button1_Click(object sender, EventArgs e)
        {
			Close();
        }

		/**
		 * Function that try to add the supplier to the product. If it can, it sets the DialogResult to OK and closes the form. If it can't, it shows an error.
		 */
        private void add_Click(object sender, EventArgs e)
        {
			if (comboBox.SelectedIndex != -1)
			{
				try
				{
					product.AddSupplier(db, allSuppliers.ToArray()[comboBox.SelectedIndex]);
					MessageBox.Show("Fournisseur ajouté au produit avec succés !");
					this.DialogResult = DialogResult.OK;
					Close();
				}
                catch
                {
					MessageBox.Show("Echec de l'ajout du fournisseur au produit. Le produit doit déjà disposer de ce fournisseur.");
                }
				
			}
            else
            {
				MessageBox.Show("Veuillez renseigner un fournisseur.");
            }

        }

        private void adddb_Click(object sender, EventArgs e)
        {
			Stocks_Fournisseur_new form = new Stocks_Fournisseur_new(db);
			if(form.ShowDialog() == DialogResult.OK)
            {
				makeComboBox();
				comboBox.SelectedIndex = comboBox.Items.Count - 1;
				comboBox.Refresh();
            }
        }
    }
}
