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
	public partial class Admin_modifier_pers : Modele_modifier
	{
		Staff staff;
		float currentSalary;
		DB db;

		/**
		 * Constructor of the class, that initialize all the fields.
		 * 
		 * @Param s the staff to modify
		 * @Param d the database
		 */
		public Admin_modifier_pers(Staff s, DB d)
		{
			InitializeComponent();
			this.staff = s;
			db = d;
			db.openConnection();
			OleDbDataReader r = db.select("Select Nom_role from rôle", null);
			while (r.Read())
			{
				roles.Items.Add(r.GetString(0));
			}


			db.closeConnection();
			date.MaxDate = DateTime.Now;
			dateEnd.MinDate = date.Value.AddDays(1);
			nameTV.Text = s.Lastname;
			firstnameTV.Text = s.Firstname;
			phoneTV.Text = s.Phone;
			addressTV.Text = s.Mail;
			roles.SelectedItem = s.Role;
			idTV.Text = s.Identify;
			string[] dt = s.Start_date.Split('-');
			string[] dte = s.End_date.Split('-');
			int y = int.Parse(dt[0]);
			int m = int.Parse(dt[1]);
			int dd = int.Parse(dt[2]);
			try
			{
				date.Value = new DateTime(int.Parse(dt[0]), int.Parse(dt[1]), int.Parse(dt[2]));
				dateEnd.Value = new DateTime(int.Parse(dte[0]), int.Parse(dte[1]), int.Parse(dte[2]));
			}
		
            catch(Exception ex)
            {
				MessageBox.Show(ex.Message + "  y =  " + y.ToString() + "   " + m.ToString() + "  " + dd.ToString() );
				Close();
            }
		
			currentSalary = s.Salary;
			actualizeSalary();
			
			Refresh();

		}

		/**
		 * Function that delete the staff
		 * 
		 */
        public override void Delete_Click(object sender, EventArgs e)
        {
			try
			{
				staff.Delete(db);
				MessageBox.Show("Suppression effectuée avec succés.");
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			catch (Exception ex)
            {
				MessageBox.Show("Erreur lors de la suppression du personnel, contactez un technicien. Message d'erreur : " + ex.Message);
            }
        }
		
		/**
		 * Function that update the current staff with the fields reseigned. If it can, it close this window. 
		 */
        public override void update_Click(object sender, EventArgs e)
        {
			
			Staff s = new Staff();
			s.Firstname = firstnameTV.Text;
			s.Lastname = nameTV.Text;
			if (idTV.Text == "" || nameTV.Text == "" || firstnameTV.Text == "")
			{
				MessageBox.Show("Veuillez renseigner tous les attributs obligatoires.");
				return;
			}
			else if (phoneTV.Text.Length != 10 || !int.TryParse(phoneTV.Text, out int d))
			{
				MessageBox.Show("Veuillez renseigner un numéro de téléphone valide");
				return;
			}
			s.Phone = phoneTV.Text;
			s.Mail = addressTV.Text;
			
			s.Role = roles.SelectedItem.ToString();
			String[] role = { s.Role };
			db.openConnection();
			OleDbDataReader oddr = db.select("select code_role from rôle where nom_role = ?", role);
            if (oddr.Read())
            {
				s.IdRole = oddr.GetInt32(0);
            }
            else
            {
				s.IdRole = 6;
            }
			db.closeConnection();
			s.Identify = idTV.Text;
			s.Start_date = date.Value.ToString("yyyy-MM-dd");
			s.End_date = dateEnd.Value.ToString("yyyy-MM-dd");
			s.Salary = currentSalary;
            try
            {
				staff.Update(db, s);
            }
            catch(Exception exc)
            {
				MessageBox.Show("Erreur lors de la modification du personnel. Veuillez réessayer avec des attributs valides et/ou, veuillez contacter un technicien en cas d'erreur logiciel. Message d'erreur : " + exc.Message);
				return;
            }

			MessageBox.Show("Personnel modifié avec succés !");
			this.DialogResult = DialogResult.OK; 
			Close();


			
			
        }

		/**
		 * Function that actualize the salary showed.
		 */
        private void actualizeSalary()
        {
			
			salary.Text = currentSalary.ToString();
			salary.Refresh();
	
		
			
        }

		/**
		 * Function that reduce the salary showed by 20.
		 */
        private void minus_salary_Click(object sender, EventArgs e)
        {
			currentSalary -= 20;
			actualizeSalary();
			
        }

        /**
         * Function that rise the salary showed by 20
         */
		private void plus_salary_Click(object sender, EventArgs e)
        {
			currentSalary += 20;
			actualizeSalary();
        }

        
		/**
		 * Function used to confirm a salary entered in the field.
		 */
        private void confirm_Click(object sender, EventArgs e)
        {
			try
			{
				currentSalary = int.Parse(salary.Text);
				
			}
			catch (Exception ex)
            {
				MessageBox.Show("Veuillez n'entrer que des valeurs numériques dans ce champ");
            }
			actualizeSalary();


		}

		/**
		 * Function that change the minimal End date to the actual Start date + 1 day.
		 */
        private void date_ValueChanged(object sender, EventArgs e)
        {
			dateEnd.MinDate = date.Value.AddDays(1);
		}

       
    }
}
