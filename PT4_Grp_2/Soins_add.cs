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
	public partial class Soins_add : Form
	{
		DB DBcon;
		public Soins_add()
		{
			InitializeComponent();
			this.DBcon = new DB("INFO-JOYEUX", "PT4_E2");
			DBcon.openConnection();
		}

		private void description_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void name_medic_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

        private void add_Click(object sender, EventArgs e)
        {
			string name = NameMedic.Text;
			string mark = Mark.Text;
			double price = 0;
			try
			{
				price = Convert.ToDouble(Price.Text);
				
			}
			catch (FormatException ef)
			{
				HintBox.Text = "Veuillez entrer un prix valide";
			}
			string desc = Desc.Text;
			int quantity = 0;
			try
			{
				 quantity = Convert.ToInt32(Quantity.Text);
			}
			catch (FormatException ef)
			{
				HintBox.Text = "Veuillez entrer un prix valide";
			}
			if (!mark.Equals("") && !price.Equals("") && !name.Equals("") && quantity != 0 && price != 0)
            {
				if(!mark.Equals("") && !price.Equals("") && !name.Equals(""))
                {
					
					string sql = "Insert Into Produit(Nom, Descrip, Quantite, Prix, Marque) values('" + name + "','" + desc + "'," + quantity + "," + price + ",'" + mark + "')";
					OleDbCommand cmdSet = new OleDbCommand(sql, DBcon.dbConnection);
					cmdSet.ExecuteNonQuery();
					HintBox.Text = "Produit ajouté avec succès";
                }
				else
				{
					HintBox.Text = "Seule la description peut être vide, veuillez vérifier que tous les champs nécessaires ont bien été remplis";
				}
			}
			
        }
    }
}
