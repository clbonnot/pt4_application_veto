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
                "left outer JOIN Personnel ON Personne.CODE_PERSONNE = Personnel.CODE_PERSONNEL " +
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
            string heures = dateStart.Value.ToString().Substring(dateStart.Value.ToString().IndexOf(':') - 2).Trim();
            string date = annee + "-" + mois + "-" + jour + " " + heures;
            Console.WriteLine(date);
            /* string request = "insert into Rendez_vous(CODE_ABONNÉ,CODE_ALBUM,DATE_EMPRUNT,DATE_RETOUR_ATTENDUE) " +
                             "values(" + codeAbo + ", ?, GETDATE(),DATEADD(Day,?,GETDATE()))";
             OleDbCommand cmdTwo = new OleDbCommand(request, dbCon);
             cmdTwo.Parameters.Add("CODE_ALBUM", OleDbType.Integer).Value = codeAlbum;
             cmdTwo.Parameters.Add("CODE_ALBUM", OleDbType.Integer).Value = delayNumber;
             cmdTwo.ExecuteNonQuery(); */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = listClient.Text;
        }

        private void listDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = listDoc.Text;
        }
    }
}
