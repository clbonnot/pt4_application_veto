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
        
        public Staff()
        {
            
        }

        public Staff(int id, DB db)
        {
            
            db.openConnection();

            String[] arg = { id.ToString() };
            OleDbDataReader reader = db.select("SELECT * FROM Personnel WHERE Code_Personnel = ?;", arg);
            
            
            if(reader.Read()){
                
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
                    if(readerRole.GetString(2) == "administrateur")
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




        private string identify;

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

        public String toString()
        {
            return this.Lastname + " | " + this.Firstname + " | " + this.Role;
        }

    }

    public class Role
    {

    }
}
