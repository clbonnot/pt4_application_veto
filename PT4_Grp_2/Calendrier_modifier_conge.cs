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
	public partial class Calendrier_modifier_conge : Modele_modifier
	{
		int codeConge, codePerso;
        DB DBcon;
		public Calendrier_modifier_conge(int codeConge,int codePerso)
		{
			this.codePerso = codePerso;
			this.codeConge = codeConge;
            this.DBcon = new DB("INFO-JOYEUX", "PT4_E2");
            DBcon.openConnection();
            InitializeComponent();
            Affichage();
		}

        public override void Delete_Click(object sender, EventArgs e)
        {
            string del = "delete from congé where code_horaire =" + codeConge + " and code_personnel=" + codePerso;
            OleDbCommand cmddel = new OleDbCommand(del, DBcon.dbConnection);
            DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment supprimer ce congé ?","Suppression", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cmddel.ExecuteNonQuery();
                MessageBox.Show("Le congé a bien été supprimé.");
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
            
            }
        }

        public override void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        public override void update_Click(object sender, EventArgs e)
        {
            string jourD = dateStart.Value.ToString().Substring(0, dateStart.Value.ToString().IndexOf('/')).Trim();
            string moisD = dateStart.Value.ToString().Substring(dateStart.Value.ToString().IndexOf('/') + 1, 2).Trim();
            string anneeD = dateStart.Value.ToString().Substring(dateStart.Value.ToString().LastIndexOf('/') + 1, 4).Trim();
            string newDateStart = anneeD + "-" + moisD + "-" + jourD + " ";

            string jourE = dateEnd.Value.ToString().Substring(0, dateEnd.Value.ToString().IndexOf('/')).Trim();
            string moisE = dateEnd.Value.ToString().Substring(dateEnd.Value.ToString().IndexOf('/') + 1, 2).Trim();
            string anneeE = dateEnd.Value.ToString().Substring(dateEnd.Value.ToString().LastIndexOf('/') + 1, 4).Trim();
            string newDateEnd = anneeE + "-" + moisE + "-" + jourE + " ";

            string update = "update horaire set debut='"+newDateStart+"'"+","+"fin ='"+newDateEnd+"'"+" where code_horaire = "+codeConge;
            OleDbCommand cmdupdate = new OleDbCommand(update, DBcon.dbConnection);

            DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment modifier ce congé ?", "Modification", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cmdupdate.ExecuteNonQuery();
                MessageBox.Show("Le congé a bien été modifié.");
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
               
            }
        }

        public void Affichage()
        {
            string sql = " select nom,prenom from personne inner join personnel on personnel.code_personne = personne.code_personne" +
                " where code_personnel=" + codePerso;
            OleDbCommand cmdPersonne = new OleDbCommand(sql, DBcon.dbConnection);
            OleDbDataReader readPersonne = cmdPersonne.ExecuteReader();
            while (readPersonne.Read())
            {
                label6.Text = readPersonne.GetString(0) + " " + readPersonne.GetString(1);
            }

            string sqlH = " select debut,fin from horaire where code_horaire = " + codeConge;
            OleDbCommand cmdHoraire = new OleDbCommand(sqlH, DBcon.dbConnection);
            OleDbDataReader readHoraire = cmdHoraire.ExecuteReader();
            while (readHoraire.Read())
            {
                dateOrigin.Text = readHoraire.GetString(0);
                label3.Text = readHoraire.GetString(1);
            }
        }
    }
}
