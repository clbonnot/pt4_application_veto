using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT4_Grp_2
{
	public partial class Stocks_add : Form
	{

		DB db;
        /**
         * Constructor of the class.
         */
		public Stocks_add(DB db)
		{
			InitializeComponent();
			this.db = db;
		}

        /**
         * Function that try to add a product in the database with all the attributes filled. If it can't, it show an error. If it can, it close the form and set the DialogResult to OK
         */
        private void add_Click(object sender, EventArgs e)
        {


            if (name.Text == null || description.Text == null || quantity.Text == null || price.Text == null || brand.Text == null)
            {
                MessageBox.Show("Veuillez renseigner tout les champs");
                return;
            }
            Regex rgx = new Regex("^[A-Z]{1}\\D+");
            if (!rgx.IsMatch(name.Text))
            {
                MessageBox.Show("Veuillez renseigner un nom valide.");
                return;
            }
                Product p = new Product();

            p.Name = name.Text;
            p.Description = description.Text;
            int q;
            if (int.TryParse(quantity.Text, out q))
            {
                p.Quantity = q;
            }
            else
            {
                MessageBox.Show("Veuillez renseigner tout les champs");
                return;
            }
            p.Brand = brand.Text;
            if (Decimal.TryParse(price.Text, out decimal pr))
            {
                p.Price = pr;
            }
            else
            {
                MessageBox.Show("Veuillez renseigner un prix valide");
                return;
            }
            MessageBox.Show(p.Price.ToString(CultureInfo.InvariantCulture));
            try
            {
                p.Flush(db);
                MessageBox.Show("Produit ajouté avec succés ! ");
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception exc)
            {

                MessageBox.Show("Erreur lors de l'ajout du produit. Verifiez que tous les champs sont valides, et contactez un technicien si besoin. Message d'erreur : " + exc);
            }

        }
    }
}
