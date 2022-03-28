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
	public partial class Calendrier_conge : Modele_calendrier
	{
		List<string> congesAffichage = new List<string>();
		List<string> personnel = new List<string>();
		DB DBcon;
		public Calendrier_conge()
		{
			InitializeComponent();
			this.DBcon = new DB("INFO-JOYEUX", "PT4_E2");
			DBcon.openConnection();
			congesAffichage.Clear();
			personnel.Clear();
		}

        public override void add_Click(object sender, EventArgs e)
        {
			Calendrier_add_conge ajout = new Calendrier_add_conge();
			ajout.Show();
        }

		private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
		{
			congesAffichage.Clear();
			personnel.Clear();
			listConges.Items.Clear();
			listPersonnel.Items.Clear();
			string date = monthCalendar1.ToString().Substring(monthCalendar1.ToString().IndexOf('/') - 2, 10);
			string jours = date.Substring(0, date.IndexOf('/'));
			string mois = date.Substring(date.IndexOf('/') + 1, 2);
			string annee = date.Substring(date.LastIndexOf('/') + 1, 4);


			string sql = "select Personne.NOM,Personne.PRENOM,Horaire.debut,Horaire.fin,Code_Horaire,Code_Personnel from Horaire " +
				"INNER JOIN Congé ON Congé.CODE_HORAIRE = Horaire.CODE_HORAIRE " +
				"INNER JOIN Personnel ON Personnel.CODE_PERSONNEL = Congé.CODE_PERSONNEL " +
				"INNER JOIN Personne ON Personne.CODE_PERSONNE = Personnel.CODE_PERSONNE "+
				"WHERE(DATEPART(yy, Horaire.debut) = " + annee + " AND DATEPART(mm, Horaire.debut) = " + mois + ")";

			OleDbCommand cmdRead = new OleDbCommand(sql, DBcon.dbConnection);
			OleDbDataReader reader = cmdRead.ExecuteReader();

			while (reader.Read())
			{
				string yDebut = reader.GetString(2).Substring(0, reader.GetString(2).IndexOf('-'));
				string mDebut = reader.GetString(2).Substring(reader.GetString(2).IndexOf('-')+1,2);
				string dDebut = reader.GetString(2).Substring(reader.GetString(2).LastIndexOf('-')+1,2);
				string dateDebut = dDebut + "/" + mDebut + "/" + yDebut;

				string yFin = reader.GetString(3).Substring(0, reader.GetString(3).IndexOf('-'));
				string mFin = reader.GetString(3).Substring(reader.GetString(3).IndexOf('-') + 1, 2);
				string dFin = reader.GetString(3).Substring(reader.GetString(3).LastIndexOf('-') + 1, 2);
				string dateFin = dFin + "/" + mFin + "/" + yFin;	

				string info = reader.GetString(1).Trim()+" est en congé depuis le "+dateDebut+" jusqu'en "+dateFin;
				congesAffichage.Add(info);
				personnel.Add(reader.GetString(0)+" "+ reader.GetString(1));
			}

			foreach (string element in congesAffichage)
			{
				listConges.Items.Add(element);
			}

			foreach (string element in personnel)
			{
				listPersonnel.Items.Add(element);
			}
			reader.Close();
	
		}

        private void listConges_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
