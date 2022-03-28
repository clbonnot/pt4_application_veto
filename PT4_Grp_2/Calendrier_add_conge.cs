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
	public partial class Calendrier_add_conge : Form
	{
		List<string> perso = new List<string>();
		DB DBcon;
		public Calendrier_add_conge()
		{
			InitializeComponent();
			this.DBcon = new DB("INFO-JOYEUX", "PT4_E2");
			DBcon.openConnection();
			listPersonnel.Items.Clear();
			ConsultPersonnel();
		}

        private void ConsultPersonnel()
        {
			perso.Clear();
			listPersonnel.Items.Clear();
			string sql = "select Personne.NOM,Personne.PRENOM from Personnel " +
			"inner join Personne on Personnel.CODE_PERSONNE = Personne.CODE_PERSONNE";


			OleDbCommand cmdRead = new OleDbCommand(sql, DBcon.dbConnection);
			OleDbDataReader reader = cmdRead.ExecuteReader();


			while (reader.Read())
			{
				string nomprenom = reader.GetString(0).Trim() + " " + reader.GetString(1).Trim();
				perso.Add(nomprenom);
			}

			foreach (string element in perso)
			{
				listPersonnel.Items.Add(element);
			}

			reader.Close();
		}
	

        private void dateEnd_ValueChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void nbJours_Click(object sender, EventArgs e)
		{

		}

        private void add_Click(object sender, EventArgs e)
        {
			int indexSdSpaceStart = dateStart.Text.IndexOf(' ', dateStart.Text.IndexOf(' ') + 1);
			int indexSdSpaceEnd = dateEnd.Text.IndexOf(' ', dateEnd.Text.IndexOf(' ') + 1);

			string jStart = dateStart.Text.Substring(dateStart.Text.IndexOf(' ')+1,2).Trim();
			string mStart = convertMonthToNumber(dateStart.Text.Substring(indexSdSpaceStart,dateStart.Text.LastIndexOf(' ')-indexSdSpaceStart).Trim());
			string yStart = dateStart.Text.Substring(dateStart.Text.LastIndexOf(' ')).Trim();

			string jEnd = dateEnd.Text.Substring(dateEnd.Text.IndexOf(' ') + 1, 2).Trim();
			string mEnd = convertMonthToNumber(dateEnd.Text.Substring(indexSdSpaceEnd, dateEnd.Text.LastIndexOf(' ') - indexSdSpaceEnd).Trim());
			string yEnd = dateEnd.Text.Substring(dateEnd.Text.LastIndexOf(' ')).Trim();

            if (jStart.Length == 1)
            {
				jStart = "0" + jStart;
            }

			if (jEnd.Length == 1)
			{
				jEnd = "0" + jEnd;
			}

			DateTime debut = new DateTime(Convert.ToInt32(yStart), Convert.ToInt32(mStart), Convert.ToInt32(jStart));
			DateTime fin = new DateTime(Convert.ToInt32(yEnd), Convert.ToInt32(mEnd), Convert.ToInt32(jEnd));
			int compare = DateTime.Compare(debut, fin);
			Console.WriteLine(compare + " " + label3.Text);
			if(compare == -1 && label3.Text != string.Empty)
            {
				string sqlConge = "insert into Horaire values(convert(date,'" + yStart + "-" + mStart + "-" + jStart + "',23)," +
					"convert(date,'" + yEnd + "-" + mEnd + "-" + jEnd + "',23))";
				string sqlLinkToEmployee = "insert into Congé values((Select code_horaire from Horaire WHERE(DATEPART(yy,horaire.debut) = " + yStart + " AND DATEPART(mm,Horaire.debut) = " + mStart + " AND DATEPART(dd,Horaire.debut)= " + jStart + "))," +
					"(SELECT code_personnel from Personnel inner join Personne on personne.CODE_PERSONNE = Personnel.CODE_PERSONNE " +
					"where personne.NOM = '" + label3.Text.Substring(0, label3.Text.IndexOf(' ')) + "' and Personne.PRENOM='" + label3.Text.Substring(label3.Text.IndexOf(' ') + 1)+"'))";

				OleDbCommand cmdConge = new OleDbCommand(sqlConge, DBcon.dbConnection);
				cmdConge.ExecuteNonQuery();
				OleDbCommand cmdEmployee = new OleDbCommand(sqlLinkToEmployee, DBcon.dbConnection);
				cmdEmployee.ExecuteNonQuery();
				MessageBox.Show("Le congé a bien été rajouté !");
				this.Close();
			}
            else
            {
				MessageBox.Show("Date non cohérente, vérifiez que la date de fin soit supérieur à la date de début !");
            }
		}

        private void button1_Click(object sender, EventArgs e)
        {
			this.Close();
        }

		private string convertMonthToNumber(string month)
        {
            switch (month)
            {
				case "janvier":
					return "01";
				case "février":
					return "02";
				case "mars":
					return "03";
				case "avril":
					return "04";
				case "mai":
					return "05";
				case "juin":
					return "06";
				case "juilet":
					return "07";
				case "août":
					return "08";
				case "septembre":
					return "09";
				case "octobre":
					return "10";
				case "novembre":
					return "11";
				case "décembre":
					return "12";
				default:
					break;
			}
			return month;
        }

        private void listPersonnel_SelectedIndexChanged(object sender, EventArgs e)
        {
			label3.Text = listPersonnel.Text;
        }
    }
}
