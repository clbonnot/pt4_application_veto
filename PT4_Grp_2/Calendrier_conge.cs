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
			comboBox1.Items.Add("Congé");
			comboBox1.Items.Add("Rendez-Vous");
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


			string sql = "select Personne.NOM,Personne.PRENOM,Horaire.debut,Horaire.fin,Horaire.Code_Horaire,Personnel.Code_Personnel from Horaire " +
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

			if (listConges.Items.Count > 0)
			{
				try
				{
					int codePerso = -1, codeHoraire = -1;
					string item = listConges.SelectedItem.ToString();
					string datedebut = item.Substring(item.IndexOf('/') - 2, 10).Trim();
					string datefin = item.Substring(item.LastIndexOf('/') - 5).Trim();

					string jD = datedebut.Substring(0, datedebut.IndexOf('/'));
					string mD = datedebut.Substring(datedebut.IndexOf('/') + 1, 2);
					string aD = datedebut.Substring(datedebut.LastIndexOf('/') + 1, 4);

					string jE = datefin.Substring(0, datefin.IndexOf('/'));
					string mE = datefin.Substring(datefin.IndexOf('/') + 1, 2);
					string aE = datefin.Substring(datefin.LastIndexOf('/') + 1, 4);

					Console.WriteLine(datedebut + " " + datefin);
					string sqlPerso = "select code_personnel from personnel inner join personne on personnel.code_personne = personne.code_personne" +
						" where personne.prenom ='" + item.Substring(0, item.IndexOf(' ')).Trim() + "'";

					string sqlHoraire = "select code_horaire from horaire where debut = '" + aD + "-" + mD + "-" + jD + "'" + " and fin ='" + aE + "-" + mE + "-" + jE + "'";

					OleDbCommand cmdRead = new OleDbCommand(sqlPerso, DBcon.dbConnection);
					OleDbDataReader reader = cmdRead.ExecuteReader();

					while (reader.Read())
					{
						codePerso = reader.GetInt32(0);
					}

					OleDbCommand cmdHoraire = new OleDbCommand(sqlHoraire, DBcon.dbConnection);
					OleDbDataReader readerHoraire = cmdHoraire.ExecuteReader();

					while (readerHoraire.Read())
					{
						codeHoraire = readerHoraire.GetInt32(0);
					}

					if (codePerso > 0 && codeHoraire > 0)
					{
						Modele_modifier edit = new Calendrier_modifier_conge(codeHoraire, codePerso);
						edit.Show();
					}
					else
					{
						MessageBox.Show("Erreur lors de la tentative de modification du congé !");
					}
				}
                catch (System.NullReferenceException)
                {

                }
			} else
            {
				MessageBox.Show("Impossible de modifier un congé si la liste est vide !");
            }
		}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (comboBox1.SelectedItem.ToString().Equals("Rendez-Vous"))
			{
				this.Hide();
				Modele_calendrier calC = new Calendrier_conge();
				calC.SetId(this.GetId());
				calC.SetName(this.GetName());
				calC.SetRights(this.roleUser);
				calC.SetRole(this.GetRole());
				calC.FormClosed += (s, args) => this.Close();
				calC.ShowDialog();
			}
		}
    }
}
