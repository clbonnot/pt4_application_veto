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
	public partial class Soins_detail : Modele
	{
		DB db;
		Medic medic;

		/**
		 * Constructor of the class
		 * 
		 * @Param db the database
		 * @Param p the drug that we want to look at
		 */
		public Soins_detail(DB db, Medic p)
		{
			InitializeComponent();
			this.db = db;
			medic = p;
			fillDetails();
			makeListSupplier();


		}

		/**
		 * Function that fills all the attributes of the drug.
		 */
		private void fillDetails()
		{
			brand.Text = medic.Brand;
			name_product.Text = medic.Name;
			price_u.Text = medic.Price.ToString();
			description.Text = medic.Description;
			stock.Text = medic.Quantity.ToString();
			Refresh();
		}

		/**
		 * Function that fill the listbox of supplier with all the supplier of the drug.
		 */
		private void makeListSupplier()
		{
			listSupplier.Items.Clear();
			foreach (Supplier s in medic.AllSuppliers)
			{
				listSupplier.Items.Add(s.ToString());
			}
			listSupplier.Refresh();
		}

		/**
		 * Function that launch a form to update the drug. If the update succeed, it actualize the informations. If the drug is deleted, it close this form.
		 */
		private void update_Click(object sender, EventArgs e)
		{
			Stocks_modifier form = new Soins_modifier(db, medic);
			DialogResult result = form.ShowDialog();
			if (result == DialogResult.OK)
			{
				fillDetails();
			}
			else if (result == DialogResult.Yes)
			{
				this.DialogResult = DialogResult.OK;
				Close();
			}
		}


		/**
		 * Function that launch a form to add a supplier to the drug.
		 */
		private void addSup_Click(object sender, EventArgs e)
		{
			Stocks_Fournisseur_add form = new Stocks_Fournisseur_add(db, medic);
			if (form.ShowDialog() == DialogResult.OK)
			{
				makeListSupplier();
			}
		}

		/**
		 * Function that delete the selected supplier of the drug.
		 */
		private void delete_Click(object sender, EventArgs e)
		{
			medic.RemoveSupplier(db, medic.AllSuppliers.ToArray()[listSupplier.SelectedIndex]);
			makeListSupplier();
		}

	}
}
