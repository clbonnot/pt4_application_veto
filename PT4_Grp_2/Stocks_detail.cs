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
	

		public Stocks_detail(DB db, Product p)
		{
			InitializeComponent();
			this.db = db;
			product = p;
			fillDetails();
			makeListSupplier();
		

		}

		private void fillDetails()
        {
			brand.Text = product.Brand;
			name_product.Text = product.Name;
			price_u.Text = product.Price.ToString();
			description.Text = product.Description;
			Refresh();
		}
		private void makeListSupplier()
        {
			listSupplier.Items.Clear();
			foreach (Supplier s in product.AllSuppliers)
            {
				listSupplier.Items.Add(s.ToString());				
            }
			listSupplier.Refresh();
        }

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

        private void addSup_Click(object sender, EventArgs e)
        {
			Stocks_Fournisseur_add form = new Stocks_Fournisseur_add(db, product);
			if(form.ShowDialog() == DialogResult.OK)
            {
				makeListSupplier();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
			product.RemoveSupplier(db, product.AllSuppliers.ToArray()[listSupplier.SelectedIndex]);
			makeListSupplier();
		}
    }
}
