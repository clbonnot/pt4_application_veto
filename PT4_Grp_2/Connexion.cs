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
    public partial class Connexion : Form
    {
        String current = "";
        public Connexion()
        {
            InitializeComponent();
            hint();
        }

        #region hint

        /**
         * Put text from textbox as a hint
         */
        private void hint()
        {
            //Text Box
            //id text box
            this.pwd.Enter += new System.EventHandler(this.setCurrent_pwd);
            this.pwd.Enter += new System.EventHandler(this.text_Enter);      
            this.pwd.Leave += new System.EventHandler(this.text_Leave);
            this.pwd.ForeColor = SystemColors.GrayText;
            //password text box
            this.identifiant.Enter += new System.EventHandler(this.setCurrent_identifiant);
            this.identifiant.Enter += new System.EventHandler(this.text_Enter);         
            this.identifiant.Leave += new System.EventHandler(this.text_Leave);
            this.identifiant.ForeColor = SystemColors.GrayText;
        }

        /**
         * Initiate the "current" string
         */
        private void setCurrent_pwd(object sender, EventArgs e)
        {
            current = "Mot de passe";
        }

        /**
         * Initiate the "current" string
         */
        private void setCurrent_identifiant(object sender, EventArgs e)
        {
            current = "Identifiant";
        }

        /**
          * Make disappear the text from the textBox on click
          */
        private void text_Enter(object sender, EventArgs e)
        {

            if (pwd.Text.Equals("Mot de passe") && current.Equals("Mot de passe"))
            {
                pwd.Clear();
                pwd.ForeColor = SystemColors.WindowText;
            }
            if (identifiant.Text.Equals("Identifiant") && current.Equals("Identifiant"))
            {
                identifiant.Clear();
                identifiant.ForeColor = SystemColors.WindowText;
            }
           
        }

        /**
          * Put a text as which looks like a hint in leave 
          */
        private void text_Leave(object sender, EventArgs e)
        {
            if (pwd.Text.Length == 0)
            {
                pwd.Text = "Mot de passe";
                pwd.ForeColor = SystemColors.GrayText;
            }
            if (identifiant.Text.Length == 0)
            {
                identifiant.Text = "Identifiant";
                identifiant.ForeColor = SystemColors.GrayText;
            }
        }
        #endregion

        private void connect_Click(object sender, EventArgs e)
        {
            string id = identifiant.Text;
            string password = pwd.Text;
            string sql = "Select Identifiant, Mot_de_passe from Personnel where LOGIN_ABONNÉ = '" + Utils.manageSingleQuote(id) + "'";
            OleDbCommand cmd = new OleDbCommand(sql);
            string motDePasseBDD = "";
            string motDePasse = pwd.Text.Trim(' ');

            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                motDePasseBDD = reader.GetString(0).Trim(' ');
            }
            string a = DecryptageDeMotDePasse(motDePasseBDD);
            if (motDePasse.Equals(DecryptageDeMotDePasse(motDePasseBDD)) && !motDePasse.Equals(""))
            {
                string nom = "";
                string prenom = "";
                string id = "";
                string sqlSet = "Select NOM_ABONNÉ, PRÉNOM_ABONNÉ, LOGIN_ABONNÉ, PASSWORD_ABONNÉ from ABONNÉS where LOGIN_ABONNÉ = '" + Utils.manageSingleQuote(pseudoTextBox.Text) + "'";
                OleDbCommand cmdSet = new OleDbCommand(sqlSet, dbCon);
                OleDbDataReader readerSet = cmdSet.ExecuteReader();
                while (readerSet.Read())
                {
                    nom = Utils.manageSingleQuote(readerSet.GetString(0));

                    prenom = Utils.manageSingleQuote(readerSet.GetString(1));

                    id = Utils.manageSingleQuote(readerSet.GetString(2));
                }
                readerSet.Close();

                this.Close();
                Abonne_Accueil AbonneAccueil = new Abonne_Accueil(nom, prenom, id);
                AbonneAccueil.StartPosition = FormStartPosition.CenterScreen;
                AbonneAccueil.ShowDialog();
            }
            else
            {
                MessageBox.Show("Le mot de passe ou l'utilisateur est incorrect");

                Console.WriteLine(motDePasse + "     " + DecryptageDeMotDePasse(motDePasseBDD));
            }
        }
    }
}
