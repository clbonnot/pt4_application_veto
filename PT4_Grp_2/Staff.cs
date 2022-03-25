using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT4_Grp_2
{
    public class Staff : People
    {

        /**
         * Basic constructor
         */
        public Staff()
        {

        }

        /**
         * Constructor of a staff which create it from the database
         * 
         * @Param id the id of the staff
         * @db the database
         */
        public Staff(int id, DB db)
        {

            db.openConnection();
            IdStaff = id;
            String[] arg = { id.ToString() };
            OleDbDataReader reader = db.select("SELECT * FROM Personnel WHERE Code_Personnel = ?;", arg);


            if (reader.Read())
            {

                this.Id = reader.GetInt32(0);
                this.Identify = reader.GetString(3);
                Password = reader.GetString(4);

                Salary = reader.GetInt32(5);
                Start_date = reader.GetString(6);
                End_date = reader.GetString(7);

                String[] arg2 = { reader.GetInt32(2).ToString() };
                OleDbDataReader readerPeople = db.select("SELECT * FROM Personne WHERE Code_Personne = ?", arg2);
                if (readerPeople.Read())
                {

                    Lastname = readerPeople.GetString(1);
                    Firstname = readerPeople.GetString(2);
                    Mail = readerPeople.GetString(3);
                    Phone = readerPeople.GetString(4);
                }
                String[] arg3 = { reader.GetInt32(1).ToString() };
                OleDbDataReader readerRole = db.select("SELECT * FROM Rôle WHERE Code_Role = ?", arg3);
                if (readerRole.Read())
                {
                    Role = readerRole.GetString(1);
                    if (readerRole.GetString(2) == "administrateur")
                    {
                        rights = true;
                    }
                    else
                    {
                        rights = false;
                    }
                }

            }

            db.closeConnection();
        }

        /**
         * Function that delete the current instance from the database
         */
        public void Delete(DB db)
        {
            db.openConnection();
 
            String[] v = { IdStaff.ToString() };
            db.nonSelect("DELETE FROM personnel where code_personnel = ?", v);
            String[] v2 = { Id.ToString() };
            try
            {
                
                db.nonSelect("DELETE FROM personne where code_personne = ?", v2);
            }
            catch
            {

            }
            db.closeConnection();
        }

        /*
         * Function that add the current instance in the database
         */
        public void Flush(DB db)
        {
            db.openConnection();
            String[] v = { Lastname, Firstname, Mail, Phone };
            int idPeople = db.insert("INSERT INTO Personne (NOM,PRENOM,MAIL,TELEPHONE) values (?,?,?,?)", v);
            int idRole;

            String[] r = { role };
            OleDbDataReader readerRole = db.select("SELECT Code_Role FROM Rôle WHERE Nom_role = ?", r);
            if (readerRole.Read())
            {
                idRole = readerRole.GetInt32(0);
            }
            else
            {
                idRole = 6;
            }
            String[] v2 = { idRole.ToString(), idPeople.ToString(), Identify, Password, Salary.ToString(), Start_date, End_date };
            db.insert("INSERT INTO PERSONNEL (Code_Role, Code_Personne, Identifiant, Mot_De_Passe, Salaire, Date_Embauche, Date_de_fin) values (?, ?, ?, ?, ?, ?,?)", v2);
            db.closeConnection();
        }




        private string identify;
        private int idStaff;
        private string password;

        private float salary;

        private string start_date;

        private string end_date;

        private string role;

        private Boolean rights;

        public string Identify { get => identify; set => identify = value; }
        public string Password { get => password; set => password = value; }
        public float Salary { get => salary; set => salary = value; }
        public string Start_date { get => start_date; set => start_date = value; }
        public string End_date { get => end_date; set => end_date = value; }
        public string Role { get => role; set => role = value; }
        public int IdStaff { get => idStaff; set => idStaff = value; }

        public String toString()
        {
            return this.Lastname + " | " + this.Firstname + " | " + this.Role;
        }

    }

    public class Role
    {

    }
}
