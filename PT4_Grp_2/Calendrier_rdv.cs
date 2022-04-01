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
	public partial class Calendrier_rdv : Modele_calendrier
	{
		List<string> rdv = new List<string>();
		DB DBcon;

		public Calendrier_rdv()
		{
			InitializeComponent();
			this.DBcon = new DB("INFO-JOYEUX", "PT4_E2");
			DBcon.openConnection();
			rdv.Clear();
			listRDV.Items.Clear();
			personnel.Items.Add("Congé");
			personnel.Items.Add("Rendez-Vous");
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		public override void add_Click(object sender, EventArgs e)
		{
			Calendrier_add_rdv ajout = new Calendrier_add_rdv();
			ajout.Show();
		}

        private void listRDV_SelectedIndexChanged(object sender, EventArgs e)
        {
			
        }

        public override void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
			rdv.Clear();
			listRDV.Items.Clear();
			string date = monthCalendar1.ToString().Substring(monthCalendar1.ToString().IndexOf('/') - 2, 10);
			string jours = date.Substring(0, date.IndexOf('/'));
			string mois = date.Substring(date.IndexOf('/') + 1, 2);
			string annee = date.Substring(date.LastIndexOf('/') + 1, 4);


			string sql = "select Personne.NOM,Personne.PRENOM,Animal.Nom_Animal,Rendez_vous.Date_rdv FROM " +
				"Rendez_vous inner join Personne on Personne.CODE_PERSONNE = Rendez_vous.Code_Personne " +
				"inner join Animal on Animal.Code_Personne = Personne.CODE_PERSONNE " +
				"WHERE(DATEPART(yy, Date_rdv) = "+ annee +" AND DATEPART(mm, Date_rdv) = "+ mois +" AND DATEPART(dd, Date_rdv) = " + jours + ")";

			OleDbCommand cmdRead = new OleDbCommand(sql, DBcon.dbConnection);
			OleDbDataReader reader = cmdRead.ExecuteReader();

			while (reader.Read())
			{
				string nomprenom = reader.GetString(0).Trim() + " " + reader.GetString(1).Trim();
				string nomAnimal = reader.GetString(2).Trim();
				string dateRDV = reader.GetDateTime(3).ToString();
				string heureRDV = dateRDV.Substring(dateRDV.IndexOf(' '), 6);
				rdv.Add("Client :"+nomprenom+" | "+"Animal : "+nomAnimal +" | "+ "Heure RDV :"+heureRDV);
			}

			foreach (string element in rdv)
			{
				listRDV.Items.Add(element);
			}

			reader.Close();
		}

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

        }

        public override void update_Click(object sender, EventArgs e)
        {
			Modele_modifier edit = new Calendrier_modifier_rdv();
			edit.ShowDialog();
        }

        private void personnel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (personnel.SelectedItem.ToString().Equals("Congé"))
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
