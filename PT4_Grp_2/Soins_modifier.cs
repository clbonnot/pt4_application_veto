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
    public partial class Soins_modifier : Modele_modifier
    {
        DB db;
        Medic medic;

        /**
         * Constructor of the class.
         * 
         * @Param db the database
         * @Param p the product to modify
         */
        public Soins_modifier(DB db, Medic s)
        {
            InitializeComponent();
            this.db = db;
            soins = s;
            name.Text = s.Name;
            description.Text = s.Description;
            quantity.Text = s.Quantity.ToString();
            price.Text = s.Price.ToString();
            brand.Text = s.Brand.ToString();
        }

        /**
         * Function that delete the product of the database. If it can, it sets the dialogresult to yes and closes the form. If it can't, it shows an error.
         */
        public override void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                medic.Delete(db);
                MessageBox.Show("Produit supprimé avec succés ! ");
                this.DialogResult = DialogResult.Yes;
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur lors de la suppression du médicament de la base de données. Contactez un technicien. Message d'erreur : " + exc);
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
            Medic s = new Medic();

            s.Name = name.Text;
            s.Description = description.Text;
            if (int.TryParse(quantity.Text, out int q))
            {
                s.Quantity = q;
            }
            else
            {
                MessageBox.Show("Veuillez renseigner tout les champs");
                return;

            }
            s.Brand = brand.Text;

            if (Decimal.TryParse(price.Text, out decimal pr))
            {
                s.Price = pr;
            }
            else
            {
                MessageBox.Show("Veuillez renseigner un prix valide");
                return;
            }

            try
            {
                medic.Update(db, s);
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
