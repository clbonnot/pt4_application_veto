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
    public partial class Clients_Race_add : Form
    {
        DB db;
        List<int> allIndexes; 
        
        /**
         * Constructor of the class
         *
         * @Param db the database
         */
        public Clients_Race_add(DB db)
        {
            InitializeComponent();
            this.db = db;
            allIndexes = new List<int>();
            makeComboBox();
        }

        /**
         * Function that fills the ComboBox of species with all the species present in the database. 
         * 
         */
        private void makeComboBox()
        {
            db.openConnection();
            OleDbDataReader r = db.select("select Code_espèce, nomEspèce from espèce", null);
            while (r.Read())
            {
                species.Items.Add(r.GetString(1));
                allIndexes.Add(r.GetInt32(0));
                
            }
            db.closeConnection();
        }

        /**
         * Function that launch a form to add a species in the database.
         */
        private void addType_Click(object sender, EventArgs e)
        {
            Clients_Type_add form = new Clients_Type_add(db);
            if(form.ShowDialog() == DialogResult.OK)
            {
                species.Items.Clear();
                makeComboBox();
                species.Refresh();
                species.SelectedIndex = species.Items.Count - 1;
            }
        }

        /**
         * Function that tries to add the race in the database. If it can, it sets the DialogResult to OK and close the form. If it can't, it shows an error.
         */
        private void validate_Click(object sender, EventArgs e)
        {
            db.openConnection();
            int idType = allIndexes.ToArray()[species.SelectedIndex];
            String[] values = { idType.ToString(), name.Text, description.Text };
            try
            {
                db.nonSelect("insert into race (Code_espèce, nomRace, descrip) values (?,?,?)", values);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur lors de l'ajout. Vérifiez que la race n'existe pas déjà pour cette espèce dans la base de donnée, ou que vous avez bien choisi une espèce. \n \n Message d'erreur : " + exc);
                db.closeConnection();
                return;
            }
            db.closeConnection();
            MessageBox.Show("Race ajoutée avec succès ! ");
            this.DialogResult = DialogResult.OK;


            Close();
        }
    }
}
