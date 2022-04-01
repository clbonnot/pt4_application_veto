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
using System.Windows.Forms.DataVisualization.Charting;

namespace PT4_Grp_2
{
    public partial class Statistiques : Modele
    {
        DB db;

        /**
         * Constructor of the class that generate a chart of the top 3 sales
         */
        public Statistiques()
        {
            InitializeComponent();
            this.db = new DB("info-joyeux", "PT4_E2");
            chart.Series.Clear();
            chart.Titles.Clear();
            db.openConnection();
            OleDbDataReader reader = db.select("select top 3 produit.nom, SUM(vente.quantite) from vente" +
                " inner join produit on vente.code_produit = produit.code_produit " +
                "group by produit.code_produit, produit.nom order by sum(vente.quantite) desc", null);
            List<string> salesSeries = new List<string>();
            List<int> salesValues = new List<int>();
            while (reader.Read())
            {
                salesSeries.Add(reader.GetString(0));
                salesValues.Add(reader.GetInt32(1));
            }

            chart.Titles.Add("Top 3 ventes");

            string[] tabS = salesSeries.ToArray();
            int[] tabValues = salesValues.ToArray();
            for (int i = 0; i < tabS.Length; i++)
            {
                Series series = chart.Series.Add(tabS[i]);
                series.Points.Add(tabValues[i]);
            }
            db.closeConnection();
            chart.Refresh();
        }


    }
}
