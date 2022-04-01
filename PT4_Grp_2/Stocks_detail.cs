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
	public partial class Stocks_detail : Modele
	{
		DB db;
		Product product;
	
		/**
		 * Constructor of the class
		 * 
		 * @Param db the database
		 * @Param p the product that we want to look at
		 */
		public Stocks_detail(DB db, Product p)
		{
			InitializeComponent();
			this.db = db;
			product = p;
			fillDetails();
			makeListSupplier();
		

		}

		/**
		 * Function that fills all the attributes of the product.
		 */
		private void fillDetails()
        {
			brand.Text = product.Brand;
			name_product.Text = product.Name;
			price_u.Text = product.Price.ToString();
			description.Text = product.Description;
			stock.Text = product.Quantity.ToString();
			Refresh();
		}

		/**
		 * Function that fill the listbox of supplier with all the supplier of the product.
		 */
		private void makeListSupplier()
        {
			listSupplier.Items.Clear();
			foreach (Supplier s in product.AllSuppliers)
            {
				listSupplier.Items.Add(s.ToString());				
            }
			listSupplier.Refresh();
        }

		/**
		 * Function that launch a form to update the product. If the update succeed, it actualize the informations. If the product is deleted, it close this form.
		 */
        private void update_Click(object sender, EventArgs e)
        {
			Stocks_modifier form = new Stocks_modifier(db, product);
			DialogResult result = form.ShowDialog();
			if (result == DialogResult.OK)
            {
				fillDetails();
            }
			else if(result == DialogResult.Yes)
            {
				this.DialogResult = DialogResult.OK;
				Close();
            }
        }

		
		/**
		 * Function that launch a form to add a supplier to the product.
		 */
        private void addSup_Click(object sender, EventArgs e)
        {
			Stocks_Fournisseur_add form = new Stocks_Fournisseur_add(db, product);
			if(form.ShowDialog() == DialogResult.OK)
            {
				makeListSupplier();
            }
        }

		/**
		 * Function that delete the selected supplier of the product.
		 */
        private void delete_Click(object sender, EventArgs e)
        {
			if (listSupplier.SelectedIndex != -1)
			{
				product.RemoveSupplier(db, product.AllSuppliers.ToArray()[listSupplier.SelectedIndex]);
				makeListSupplier();
			}
		}
    }
}
