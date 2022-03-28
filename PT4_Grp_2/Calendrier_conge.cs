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
		List<string> conges = new List<string>();
		List<string> personnel = new List<string>();
		DB DBcon;
		public Calendrier_conge()
		{
			InitializeComponent();
			this.DBcon = new DB("INFO-JOYEUX", "PT4_E2");
			DBcon.openConnection();
			conges.Clear();
			personnel.Clear();
		}

        public override void add_Click(object sender, EventArgs e)
        {
			Calendrier_add_conge ajout = new Calendrier_add_conge();
			ajout.Show();
        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
			conges.Clear();
			personnel.Clear();
			listConges.Items.Clear();
			listPersonnel.Items.Clear();
			string date = monthCalendar1.ToString().Substring(monthCalendar1.ToString().IndexOf('/') - 2, 10);
			Console.WriteLine(date);
			string jours = date.Substring(0, date.IndexOf('/'));
			string mois = date.Substring(date.IndexOf('/') + 1, 2);
			string annee = date.Substring(date.LastIndexOf('/') + 1, 4);


			/*string sql = "select Personne.NOM,Personne.PRENOM,Animal.Nom_Animal,Rendez_vous.Date_rdv FROM " +
				"Rendez_vous inner join Personne on Personne.CODE_PERSONNE = Rendez_vous.Code_Personne " +
				"inner join Animal on Animal.Code_Personne = Personne.CODE_PERSONNE " +
				"WHERE(DATEPART(yy, Date_rdv) = " + annee + " AND DATEPART(mm, Date_rdv) = " + mois + " AND DATEPART(dd, Date_rdv) = " + jours + ")";

			OleDbCommand cmdRead = new OleDbCommand(sql, DBcon.dbConnection);
			OleDbDataReader reader = cmdRead.ExecuteReader();*/
		}
    }
}
