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
        static DB connexion = new DB("INFO-JOYEUX", "PT4_E2");
        OleDbConnection dbCon = connexion.getDbConnection();
        public Calendrier_modifier_rdv()
		{
			InitializeComponent();
		}

        public void ConsultClient()
        {
            client.Clear();
            listClient.Items.Clear();
            string sql = "select NOM,PRENOM from Personne " +
                "left outer JOIN Personnel ON Personne.CODE_PERSONNE = Personnel.CODE_PERSONNEL " +
                "WHERE Personnel.CODE_PERSONNEL is null ";


            OleDbCommand cmdRead = new OleDbCommand(sql, dbCon);
            OleDbDataReader reader = cmdRead.ExecuteReader();


            while (reader.Read())
            {
                string nomprenom = reader.GetString(0).Trim() + reader.GetString(1).Trim();
                client.Add(nomprenom);
            }

            foreach (string element in client)
            {
                listClient.Items.Add(element);
            }

            reader.Close();
        }
    }
}
