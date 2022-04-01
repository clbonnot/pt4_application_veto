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
    public partial class Clients_Animal : Form
    {

        public DB db;
        public List<int> allTypesIndexes;
        public List<int> allRacesIndexes;


        public Clients_Animal(){
         
        }

        /**
         * Constructor of the class.
         */
        public Clients_Animal(DB db)
        {
            InitializeComponent();
            this.db = db;
            makeSpecies();
            species.Refresh();
        
        }
        
        /**
         * Function that calcule the age of the animal and refresh the value of the age's label.
         */
        public void makeAge()
        {
            age.Text = "" + Math.Floor((DateTime.Now - date.Value).Days / 365.25) + " ans et " + Math.Floor((DateTime.Now - date.Value).Days%365.25 / 30.5) + " mois";
            age.Refresh();
        }

        /**
         * Function that fill the combobox of the species with all the species in the database.
         */
        private void makeSpecies()
        {
            species.Items.Clear();
           
            db.openConnection();
            allTypesIndexes = new List<int>();
            OleDbDataReader reader = db.select("select code_espèce, nomespèce from espèce", null);
            while (reader.Read())
            {
                allTypesIndexes.Add(reader.GetInt32(0));
                species.Items.Add(reader.GetString(1));
            }
            db.closeConnection();
            species.SelectedIndex = 0;
        }

        /**
         * Function that create an animal with all the attribute filled.
         * 
         * @Return the animal.
         */
        public Animal validateAnimal()
        {
            Animal a = new Animal();
            if (name.Text.Length > 1)
            {
                a.Name = name.Text;
            }
            else
            {
                MessageBox.Show("Veuillez renseigner un nom valide.");
                return null;
            }
            a.Date_birth = date.Value.ToString("yyyy-MM-dd");
            int m = 0;
            if (int.TryParse(mass.Text, out m))
            {
                a.Mass = m;
            }
            else
            {

                MessageBox.Show("Veuillez renseigner un poids valide");
                return null;
            }
            a.Sex = sexe.Text;
            a.Note = notes.Text;
            try
            {
                a.Idrace = allRacesIndexes.ToArray()[races.SelectedIndex];
                a.Idtype = allTypesIndexes.ToArray()[species.SelectedIndex];
            }
            catch
            {
                MessageBox.Show("Veuillez selectionner une race et une espèce");
                return null;
            }
            
            return a;
        }

        /**
         * Function that filled the combobox of the races with all the races present in the database.
         */
        private void makeRaces(int idType)
        {
            races.Items.Clear();
            List<int> lr  = new List<int>();
            db.openConnection();
            String[] arg = { idType.ToString() };
            allRacesIndexes = new List<int>();
            OleDbDataReader reader = db.select("select code_race, nomrace from race where code_espèce = ?",arg );
            while (reader.Read())
            {
                allRacesIndexes.Add(reader.GetInt32(0));
                races.Items.Add(reader.GetString(1));
            }
            db.closeConnection();
            if (races.Items.Count != 0)
            {
                races.SelectedIndex = 0;
            }
            else
            {
                races.SelectedIndex = -1;
                races.Text = "";
            }
            races.Refresh();
            
        }

        /**
         * Function that launch a form to add a race in the database. If the add succeed, it actualize the comboBoxes.
         */
        private void addRace_Click(object sender, EventArgs e)
        {
            Clients_Race_add form = new Clients_Race_add(db);
            if(form.ShowDialog() == DialogResult.OK)
            {
                makeSpecies();
                species.Refresh();
           
            }
        }

        /**
         * Function that launch a form to add a species in the database. If the add succeed, it actualise the comboBoxes and select the new species.
         */
        private void addSpecies_Click(object sender, EventArgs e)
        {
            Clients_Type_add form = new Clients_Type_add(db);
            if(form.ShowDialog() == DialogResult.OK)
            {
                makeSpecies();
                int nbSpecies = species.Items.Count;
                makeRaces(allTypesIndexes.ToArray()[nbSpecies -1]);
                species.SelectedIndex = nbSpecies - 1;
                species.Refresh();

            }
            
        }

        /**
         * Function that actualise the combobox of races with the species selected.
         */
        private void species_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            makeRaces(allTypesIndexes.ToArray()[species.SelectedIndex]);
        }

        /**
         * Function that close the form.
         */
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /**
         * Function that call makeAge()
         */
        private void date_ValueChanged(object sender, EventArgs e)
        {
            makeAge();
        }
    }
}
