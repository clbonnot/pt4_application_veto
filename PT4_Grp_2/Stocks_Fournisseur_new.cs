using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT4_Grp_2
{
    public partial class Stocks_Fournisseur_new : Form
    {
        DB db;

        /**
         * Constructor of the class
         * 
         * @param db the database
         */
        public Stocks_Fournisseur_new(DB db)
        {
            InitializeComponent();
            this.db = db;
        }

   
        /**
         * Function that try to add the supplier to the product. If it can, it set the DialogResult to OK and close the form. If it can't, it shows an error.
         */
        private void add_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            s.Name = name.Text;
            s.Phone = phone.Text;
            s.Web = web.Text;
            Regex rgx = new Regex("^[A-Z]{1}\\D+");
            if (!rgx.IsMatch(name.Text))
            {
                MessageBox.Show("Veuillez renseigner un nom valide.");
                return;
            }
            try
            {
                s.Flush(db);
                MessageBox.Show("Fournisseur ajouté à la base de données avec succés ! ");
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Erreur lors de l'ajout du fournisseur. Vérifiez que vous avez renseigné tout les champs. Message d'erreur : " + exc);
            }
        }
    }
}
