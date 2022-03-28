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
	public partial class Calendrier_modifier_rdv : Modele_modifier
	{
        List<string> client = new List<string>();
        List<string> rdv = new List<string>();
        DB DBcon;
        public Calendrier_modifier_rdv()
		{
			InitializeComponent();
            this.DBcon = new DB("INFO-JOYEUX", "PT4_E2");
            DBcon.openConnection();
            client.Clear();
            rdv.Clear();
            listBox1.Items.Clear();
            listClient.Items.Clear();
            ConsultClient();
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
                string nomprenom = reader.GetString(0).Trim() +" "+ reader.GetString(1).Trim();
                client.Add(nomprenom);
            }

            foreach (string element in client)
            {
                listClient.Items.Add(element);
            }

            reader.Close();
            
        }

        public override void Delete_Click(object sender, EventArgs e)
        {
            if(labelnom.Text.Length > 0 && labelrdv.Text.Length > 0)
            {
                string sql = "delete from rendez_vous where date_rdv = '" + labelrdv.Text + "'";
            
                OleDbCommand cmd = new OleDbCommand(sql, DBcon.dbConnection);
                DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment supprimer ce RDV ?", "Suppression", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Le RDV a bien été supprimé.");
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            } 
            else
            {
                MessageBox.Show("Veuillez sélectionner un rendez-vous.");
            }
        }

        public override void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        public override void update_Click(object sender, EventArgs e)
        {
            string jour = dateStart.Value.ToString().Substring(0, dateStart.Value.ToString().IndexOf('/')).Trim();
            string mois = dateStart.Value.ToString().Substring(dateStart.Value.ToString().IndexOf('/') + 1, 2).Trim();
            string annee = dateStart.Value.ToString().Substring(dateStart.Value.ToString().LastIndexOf('/') + 1, 4).Trim();
            string date = annee + "-" + mois + "-" + jour + " ";

            if (labelrdv.Text.Length > 0 && textBox2.Text != string.Empty && textBox3.Text != string.Empty && labelnom.Text.Length > 1)
            {
                string heure = "";
                string minutes = "";
                if (textBox2.Text.Trim().Length.Equals(1))
                {
                    heure = "0" + textBox2.Text.Trim();
                }
                else
                {
                    heure = textBox2.Text.Trim();
                }
                if (textBox3.Text.Trim().Length.Equals(1))
                {
                    minutes = "0" + textBox3.Text.Trim();
                }
                else
                {
                    minutes = textBox3.Text.Trim();
                }
                string dateComplète = date + heure + ":" + minutes+":00";
                string sql = "update rendez_vous set date_rdv = convert(datetime,'"+dateComplète+"',20) where date_rdv = '" + labelrdv.Text + "'";

                OleDbCommand cmd = new OleDbCommand(sql, DBcon.dbConnection);
                DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment modifier ce RDV ?", "Modification", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Le RDV a bien été modifié.");
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            } 
            else
            {
                MessageBox.Show("Veuillez sélectionner un rendez-vous.");
            }
        }

        private void listClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelnom.Text= listClient.SelectedItem.ToString();
            ConsultRDV();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                labelrdv.Text = listBox1.SelectedItem.ToString();
            }
        }

        public void ConsultRDV()
        {
            rdv.Clear();
            listBox1.Items.Clear();
            string sql = "select Date_rdv from Rendez_vous " +
                "where Rendez_vous.code_personne = (SELECT CODE_PERSONNE FROM PERSONNE WHERE NOM='"+labelnom.Text.Substring(0,labelnom.Text.IndexOf(' ')).Trim()+"'"+
                " and PRENOM='"+ labelnom.Text.Substring(labelnom.Text.IndexOf(' ')+1).Trim() + "')";


            OleDbCommand cmdRead = new OleDbCommand(sql, DBcon.dbConnection);
            try
            {
                OleDbDataReader reader = cmdRead.ExecuteReader();
                while (reader.Read())
                {
                    string date = reader.GetDateTime(0).ToString();
                    rdv.Add(date);
                    Console.WriteLine(date);
                }

                foreach (string element in rdv)
                {
                    listBox1.Items.Add(element);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur prénom + nom identique à une autre personne");
            }
        }
    }
}
