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
	public partial class Calendrier_add_rdv : Form
	{
		List<string> docs = new List<string>();
		List<string> client = new List<string>();
        List<string> animauxClient = new List<string>();
        DB DBcon;
        public Calendrier_add_rdv()
		{
			InitializeComponent();
            this.DBcon = new DB("INFO-JOYEUX", "PT4_E2");
            DBcon.openConnection();
            refreshLists();
            ConsultClient();
            ConsultDocs();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

        public void ConsultClient()
        {
            client.Clear();
            listClient.Items.Clear();           
            string sql = "select NOM,PRENOM from Personne " +
                "left outer JOIN Personnel ON Personne.CODE_PERSONNE = Personnel.CODE_PERSONNE " +
                "WHERE Personnel.CODE_PERSONNEL is null ";


            OleDbCommand cmdRead = new OleDbCommand(sql, DBcon.dbConnection);
            OleDbDataReader reader = cmdRead.ExecuteReader();


            while (reader.Read())
            {
                string nomprenom = reader.GetString(0).Trim() + " "+ reader.GetString(1).Trim();               
                client.Add(nomprenom);
            }

            foreach (string element in client)
            {
                listClient.Items.Add(element);
            }

            reader.Close();
        }

        public void ConsultDocs()
        {
            docs.Clear();
            listDoc.Items.Clear();
            string sql = "select Personne.NOM,Personne.PRENOM from Personnel " +
            "inner join Personne on Personnel.CODE_PERSONNE = Personne.CODE_PERSONNE";


            OleDbCommand cmdRead = new OleDbCommand(sql, DBcon.dbConnection);
            OleDbDataReader reader = cmdRead.ExecuteReader();


            while (reader.Read())
            {
                string nomprenom = reader.GetString(0).Trim() + " " + reader.GetString(1).Trim();
                docs.Add(nomprenom);
            }

            foreach (string element in docs)
            {
                listDoc.Items.Add(element);
            }

            reader.Close();
        }

        public void refreshLists()
        {
            client.Clear();
            docs.Clear();
            animauxClient.Clear();
            listClient.Items.Clear();
            listDoc.Items.Clear();
            listBoxAnimal.Items.Clear();    
        }

        private void add_Click(object sender, EventArgs e)
        {
            string jour = dateStart.Value.ToString().Substring(0,dateStart.Value.ToString().IndexOf('/')).Trim();
            string mois = dateStart.Value.ToString().Substring(dateStart.Value.ToString().IndexOf('/')+1,2).Trim();
            string annee = dateStart.Value.ToString().Substring(dateStart.Value.ToString().LastIndexOf('/')+1,4).Trim();
            string date = annee + "-" + mois + "-" + jour + " ";
            int codeAnimal = -1;
            int codePersonne = -1;
            int codePersonnel = -1;

            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty && textBox4.Text != string.Empty 
                && textBox5.Text != string.Empty && textBox6.Text != string.Empty
                && Convert.ToInt32(textBox2.Text.Trim()) < 25 && Convert.ToInt32(textBox2.Text.Trim()) >= 0
                && Convert.ToInt32(textBox6.Text.Trim()) < 60 && Convert.ToInt32(textBox6.Text.Trim()) >= 0)
            {
                string heure="";
                string minutes="";
                if (textBox2.Text.Trim().Length.Equals(1))
                {
                   heure = "0" + textBox2.Text.Trim();
                }
                else
                {
                    heure = textBox2.Text.Trim();
                }
                if (textBox6.Text.Trim().Length.Equals(1))
                {
                    minutes = "0" + textBox6.Text.Trim();
                } else
                {
                    minutes = textBox6.Text.Trim();
                }
                Console.WriteLine(textBox3.Text.Substring(0, textBox3.Text.IndexOf(' ')));
                Console.WriteLine(textBox3.Text.Substring(textBox3.Text.IndexOf(' ') + 1));
                string sqlAnimal = "select Animal.Code_animal from Animal " +
                "inner join Personne on Animal.Code_Personne = Personne.CODE_PERSONNE " +
                "WHERE Personne.CODE_PERSONNE = (SELECT CODE_PERSONNE FROM PERSONNE WHERE Personne.NOM = '"+
                "" + textBox3.Text.Substring(0, textBox3.Text.IndexOf(' ')) + "' " +
                "and Personne.PRENOM='" + textBox3.Text.Substring(textBox3.Text.IndexOf(' ') + 1) + "') and Animal.Nom_Animal = '" + textBox5.Text.Trim() + "'";

                string sqlPersonne = "select Personne.Code_Personne from Personne " +
                "WHERE Personne.NOM = '" +
                "" + textBox3.Text.Substring(0, textBox3.Text.IndexOf(' ')) + "' " +
                "and Personne.PRENOM='" + textBox3.Text.Substring(textBox3.Text.IndexOf(' ') + 1) + "'";

                string sqlDoc = "select Personnel.Code_Personnel from Personnel " +
                "inner join Personne on Personnel.CODE_PERSONNE = Personne.CODE_PERSONNE" +
                " where Personne.NOM = '" + textBox4.Text.Substring(0, textBox4.Text.IndexOf(' ')) + "'";

                string dateComplète = date + heure +":" + minutes +":"+"00";

                OleDbCommand cmdReadAnimal = new OleDbCommand(sqlAnimal, DBcon.dbConnection);
                OleDbDataReader readerAnimal = cmdReadAnimal.ExecuteReader();
                while (readerAnimal.Read())
                {
                    codeAnimal = readerAnimal.GetInt32(0);
                }

                OleDbCommand cmdReadPersonne = new OleDbCommand(sqlPersonne, DBcon.dbConnection);
                OleDbDataReader readerPersonne = cmdReadPersonne.ExecuteReader();
                while (readerPersonne.Read())
                {
                    codePersonne = readerPersonne.GetInt32(0);
                }

                OleDbCommand cmdReadDoc = new OleDbCommand(sqlDoc, DBcon.dbConnection);
                OleDbDataReader readerDoc = cmdReadDoc.ExecuteReader();
                while (readerDoc.Read())
                {
                    codePersonnel = readerDoc.GetInt32(0);
                }

                string request = "insert into Rendez_vous(Code_Animal,Code_Personne,Code_Personnel,Date_rdv,motif) " +
                    "values (?, ?,?, convert(datetime,'"+dateComplète+"',20),'"+ Utils.manageSingleQuote(textBox1.Text) +"')";
                OleDbCommand cmdRequest = new OleDbCommand(request, DBcon.dbConnection);

                cmdRequest.Parameters.Add("Code_Animal", OleDbType.Integer).Value = codeAnimal;
                cmdRequest.Parameters.Add("Code_Personne", OleDbType.Integer).Value = codePersonne;
                cmdRequest.Parameters.Add("Code_Personnel", OleDbType.Integer).Value = codePersonnel;
                DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment ajouter ce RDV ?", "Ajout RDV", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cmdRequest.ExecuteNonQuery();
                    MessageBox.Show("Le RDV a bien été crée.");
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
                
            }
            else
            {
                MessageBox.Show("Un élément nécessaire à l'ajout du RDV est manquant!");
            }

            Console.WriteLine(date);
            
        }

            private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Clear();
            animauxClient.Clear();
            listBoxAnimal.Items.Clear();
            textBox3.Text = listClient.Text;
            string sql = "select Animal.Nom_Animal from Animal " +
                "inner join Personne on Animal.Code_Personne = Personne.CODE_PERSONNE " +
                "WHERE Personne.CODE_PERSONNE = (SELECT CODE_PERSONNE FROM PERSONNE WHERE Personne.NOM = '" +
                ""+textBox3.Text.Substring(0, textBox3.Text.IndexOf(' ')) + "' " +
                "and Personne.PRENOM='"+textBox3.Text.Substring(textBox3.Text.IndexOf(' ')+1)+"')";
            OleDbDataReader reader = null;

            OleDbCommand cmdRead = new OleDbCommand(sql, DBcon.dbConnection);
            try
            {
                OleDbDataReader reader1 = cmdRead.ExecuteReader();
                reader = reader1;
            }
            catch (Exception ex)
            {
            }
            if (reader != null)
            {
                while (reader.Read())
                {
                    string nom = reader.GetString(0).Trim();
                    animauxClient.Add(nom);
                }

                foreach (string element in animauxClient)
                {
                    listBoxAnimal.Items.Add(element);
                }
                reader.Close();
            }
        }
    

        private void listDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = listDoc.Text;
        }

        private void listBoxAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text = listBoxAnimal.Text;
        }
    }
}
