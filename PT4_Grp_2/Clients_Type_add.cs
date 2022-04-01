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
    public partial class Clients_Type_add : Form
    {

        DB db;

        /**
         * Constructo of the class.
         * 
         * @Param db
         */
        public Clients_Type_add(DB db)
        {
            
            InitializeComponent();
            this.db = db;


        }

        /**
         * Function that tries to insert the species in the database. If it can, it sets the DialogResult to ok and close the form. If it can't, it shows an error.
         */
        private void validate_Click(object sender, EventArgs e)
        {
            db.openConnection();
            
            String[] values = { name.Text, description.Text };
            int id;
            try
            {
                id = db.insert("Insert into espèce (nomespèce, descrip) values (? , ?)", values);

            }
            catch(Exception exc)
            {
                MessageBox.Show("Erreur lors de l'ajout. Vérifiez que l'espèce n'existe pas déjà dans la base de donnée. Message d'erreur : " + exc);
                db.closeConnection();
                return;
            }
            db.closeConnection();
            MessageBox.Show("Espèce ajoutée avec succès ! ");
            this.DialogResult = DialogResult.OK;
            Close();
            
        }



    }
}
