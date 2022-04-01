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
    public partial class Clients_Animal_Modifier : Clients_Animal
    {
        Animal animal;

        public Clients_Animal_Modifier()
        {

        }

        /**
         * Constructor of the class
         * 
         * @Param db the database
         * @Param a the animal to mmodify 
         */
        public Clients_Animal_Modifier(DB db, Animal a) : base(db)
        {
            InitializeComponent();
            this.animal = a;
            name.Text = a.Name;
            sexe.Text = a.Sex;
            species.SelectedItem = a.typeInfo(db)[0];
            races.SelectedItem = a.raceInfo(db)[0];
            mass.Text = a.Mass.ToString();
            if (a.Date_birth != "uknown")
            {
                string[] dateSplit = a.Date_birth.Split('-');

                date.Value = new DateTime(int.Parse(dateSplit[0]), int.Parse(dateSplit[1]), int.Parse(dateSplit[2]));

                makeAge();
            }

        }


        /**
         * Function that try to update the animal. If it can, close the form and set the DialogResult to ok.
         */
        private void update_Click(object sender, EventArgs e)
        {
            Animal a = validateAnimal();
            a.Owner = animal.Owner;
            if (a != null)
            {
                try
                {
                    animal.update(db, a);
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Modification de l'animal " + a.Name + " a été effectuée avec succés ! ");
                    Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Erreur lors de la modification de l'animal. Vérifiez que tout les champs sont valides, et contactez un technicien si besoin. Message d'erreur : " + exc);

                }

            }
            else
            {
                MessageBox.Show("Erreur lors de la modification de l'animal. Veuillez remplir tout les champs.");
            }
            
        }

        /**
         * Function that try to delete the animal of the database, with the same concequences as the function above.
         */
        private void delete_Click(object sender, EventArgs e)
        {
            Modele_delete form = new Modele_delete();
            if(form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    animal.delete(db);
                    MessageBox.Show("Animal supprimé avec succés ! ");
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                catch(Exception exc)
                {
                    MessageBox.Show("Echec lors de la suppression de l'animal. Contactez un technicien. Message d'erreur : " + exc);
                }
            }
        }
    }
}
