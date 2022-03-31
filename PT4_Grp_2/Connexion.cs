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
        DB DBcon;

        public Connexion()
        {
            InitializeComponent();
            hint();
            this.DBcon = new DB("INFO-JOYEUX", "PT4_E2");
            DBcon.openConnection();
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
                pwd.PasswordChar = '*';
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
                pwd.PasswordChar = '\0';
            }
            if (identifiant.Text.Length == 0)
            {
                identifiant.Text = "Identifiant";
                identifiant.ForeColor = SystemColors.GrayText;
            }
        }
        #endregion
        /*
         * This void compare the id and password with the one in the database and get the user's role and rights
         */
        private void connect_Click(object sender, EventArgs e)
        {
            string id = identifiant.Text;
            string password = pwd.Text;
            string sqlSet = "Select  Identifiant, Mot_de_passe, Code_Personnel from Personnel where identifiant = '" + Utils.manageSingleQuote(id) + "'";
            OleDbCommand cmd = new OleDbCommand(sqlSet, DBcon.dbConnection);
            string motDePasseBDD = "";
            string motDePasse = pwd.Text.Trim(' ');
            int idStaff = 0;
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                motDePasseBDD = reader.GetString(1).Trim(' ');
                idStaff = reader.GetInt32(2);
            }
            //string a = DecryptageDeMotDePasse(motDePasseBDD);
            if (motDePasse.Equals(motDePasseBDD) && !motDePasseBDD.Equals(""))
            {
                string sql = "select nom_role, droit from Rôle inner join Personnel on Personnel.CODE_ROLE = Rôle.CODE_ROLE " +
                "WHERE Personnel.IDENTIFIANT = '" + Utils.manageSingleQuote(id) + "'";
                OleDbCommand cmdSet = new OleDbCommand(sql, DBcon.dbConnection);
                
                OleDbDataReader readerSet = cmdSet.ExecuteReader();
                string role = "";
                string rights = "";
                while (readerSet.Read())
                {
                    role = Utils.manageSingleQuote(readerSet.GetString(0));
                    rights = Utils.manageSingleQuote(readerSet.GetString(1));
                }
                readerSet.Close();
                string sqlName = "select NOM from Personne inner join Personnel on Personnel.CODE_Personne = Personne.CODE_Personne " +
                "WHERE Personnel.IDENTIFIANT = '" + Utils.manageSingleQuote(id) + "'";
                OleDbCommand cmdName = new OleDbCommand(sqlName, DBcon.dbConnection);

                OleDbDataReader readerName = cmdName.ExecuteReader();
                string name = "";
                
                while (readerName.Read())
                {
                    name = Utils.manageSingleQuote(readerName.GetString(0));
                   
                }
                readerName.Close();
                DBcon.closeConnection();
                
                Modele Mod = new Paniers();
                Mod.SetId(idStaff);
                MessageBox.Show(idStaff.ToString());
                Mod.SetRole(role);
                Mod.SetRights(rights);   
                Mod.SetName(name);
                if (Mod.GetAdmin())
                {
                    Admin admin = new Admin();
                    admin.StartPosition = FormStartPosition.CenterScreen;
                    Mod.ShowDialog();
                }
                Mod.StartPosition = FormStartPosition.CenterScreen;
                Mod.ShowDialog();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Le mot de passe ou l'utilisateur est incorrect");

                Console.WriteLine(motDePasse + "     " /*+ DecryptageDeMotDePasse(motDePasseBDD)*/);
            }
            
        }

        private void pwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
