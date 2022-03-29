using System;
using System.Windows.Forms;

namespace PT4_Grp_2
{
    public partial class Clients_Animal_Add : Clients_Animal
    {

        Client client;


        public Clients_Animal_Add(DB db, Client c) : base(db)
        {
            InitializeComponent();
            client = c;
            makeAge();
        }



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
