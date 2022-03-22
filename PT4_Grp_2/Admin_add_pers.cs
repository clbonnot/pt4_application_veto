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
	public partial class Admin_add_pers : Modele_add_pers
	{

        DB db;
		public Admin_add_pers(DB d)
		{
			InitializeComponent();
            db = d;
            db.openConnection();
            OleDbDataReader r = db.select("Select Nom_role from rôle",null);
            while (r.Read())
            {
                role.Items.Add(r.GetString(0));
            }


		}

        /**
         * Function that add a staff in the database basing on the attributes of the form.
         */
         public override void valider_Click(object sender, EventArgs e)
        {

            
            if (password.Text == "aaaaaa" || LastName.Text == "Nom" || Phone.Text == "Téléphone")
            {
                MessageBox.Show("Veuillez renseigner tous les attributs obligatoires.");
            }
            else if (Phone.Text.Length != 10)
            {
                MessageBox.Show("Veuillez renseigner un numéro de téléphone valide");
            }
            
            else
            {
                Staff s = new Staff();
                s.Identify = Identify.Text;
                s.Lastname = LastName.Text;
                s.Firstname = FirstName.Text;
                s.Phone = Phone.Text;
                s.Mail = Address.Text;
                s.Password = password.Text;
                s.End_date = endDate.Text;
                int sal;
                if (Int32.TryParse(salary.Text, out sal)) {
                    s.Salary = sal;
                }
                else
                {
                    MessageBox.Show("Veuillez renseigner un salaire valide.");
                    return;
                }
                s.Role = role.SelectedItem.ToString();
                s.Start_date = DateTime.Now.ToString("yyyy-MM-dd");
                
                try{
                    s.Flush(db);
                    MessageBox.Show("Personnel ajouté avec succès !");
                    Close();
                }
                catch(Exception exc)
                {
                    MessageBox.Show("Echec lors de l'ajout du personnel, vérifiez que les attributs sont valides.");
                }
                
            
                
                
            }
        }

    
    }
}
