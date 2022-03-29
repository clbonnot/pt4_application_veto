using System;
using System.Windows.Forms;

namespace PT4_Grp_2
{
    public partial class Clients_Animal_Add : Clients_Animal
    {

        Client client;

        /**
         * Constructor of the class.
         * 
         * @Param db the database
         * @Param c the animal owner's
         */
        public Clients_Animal_Add(DB db, Client c) : base(db)
        {
            InitializeComponent();
            client = c;
            makeAge();
        }


        /**
         * Function that try to add the animal in the database. If it can, it closes the form and set the DialogResult to Ok. If it can't, it shows an error message.
         */
        private void add_Click(object sender, EventArgs e)
        {
            Animal a = validateAnimal();
            a.Owner = client;
            try
            {
                a.Flush(db);
                client.Animals.Add(a);
                MessageBox.Show("L'animal " + a.Name + " a été ajouté avec succés !");
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Echec lors de l'ajout de l'animal. Vérifiez tout les champs, et contactez un technicien si besoin. Message d'erreur : " + exc);

            }


        }
    }
}
