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
	public partial class Stocks_modifier : Modele_modifier
	{
        DB db;
        Product product;

        /**
         * Constructor of the class.
         * 
         * @Param db the database
         * @Param p the product to modify
         */
		public Stocks_modifier(DB db, Product p)
		{
			InitializeComponent();
            this.db = db;
            product = p;
            name.Text = p.Name;
            description.Text = p.Description;
            quantity.Text = p.Quantity.ToString();
            price.Text = p.Price.ToString();
            brand.Text = p.Brand.ToString();
		}

        /**
         * Function that delete the product of the database. If it can, it sets the dialogresult to yes and closes the form. If it can't, it shows an error.
         */
        public override void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                product.Delete(db);
                MessageBox.Show("Produit supprimé avec succés ! ");
                this.DialogResult = DialogResult.Yes;
                Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Erreur lors de la suppression du produit de la base de données. Contactez un technicien. Message d'erreur : " + exc);
            }
        }

        /**
         * Function that update the product with all the attributes filled. If it can, it sets the dialogresult to ok and closes the form. If it can't, it shows an error.
         */
        public override void update_Click(object sender, EventArgs e)
        {
            if (name.Text == null || description.Text == null || quantity.Text == null || price.Text == null || brand.Text == null)
            {
                MessageBox.Show("Veuillez renseigner tout les champs");
                return;
            }
            Product p = new Product();

            p.Name = name.Text;
            p.Description = description.Text;
            if (int.TryParse(quantity.Text, out int q))
            {
                p.Quantity = q;
            }
            else
            {
                MessageBox.Show("Veuillez renseigner tout les champs");
                return;

            }
            p.Brand = brand.Text;

            if( Decimal.TryParse(price.Text, out decimal pr))
            {
                p.Price = pr;
            }
            else
            {
                MessageBox.Show("Veuillez renseigner un prix valide");
                return;
            }

            try
            {
                product.Update(db, p);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur lors de la modification du produit. Veuillez réessayer avec des attributs valides et/ou, veuillez contacter un technicien en cas d'erreur logiciel. Message d'erreur : " + exc.Message);
                return;
            }

            MessageBox.Show("Produit modifié avec succés !");
            this.DialogResult = DialogResult.OK;
            Close();
        }

    }
}
