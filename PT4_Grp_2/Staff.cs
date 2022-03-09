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

            String[] arg = { "" + id };
            OleDbDataReader reader = db.select("SELECT Code_Personnel FROM Personnel WHERE Code_Personnel = ?", arg);
            this.id = id;
            
            if(reader.Read()){
                id = reader.GetInt32(0);
                String[] arg2 = { "" + reader.GetInt32(2)};
                OleDbDataReader readerPeople = db.select("SELECT * FROM Personne WHERE Code_Persone = ?", arg);
                if (readerPeople.Read())
                {
                    lastname = readerPeople.GetString(1);
                    firstname = readerPeople.GetString(2);
                    mail = readerPeople.GetString(3);
                    phone = readerPeople.GetInt32(4);
                }
                identify = reader.GetString(3);
                password = reader.GetString(4);
                salary = reader.GetInt32(5);
                start_date = reader.GetDateTime(6);
                end_date = reader.GetDateTime(7);

            }

            db.closeConnection();
        }
            
        
        public int id
        {
            get { return id; }
            set { id = value; }
        }
        
        public string identify
        {
            get { return password; }
            set { password = value; }
        }
        public string password
        {
            get { return password; }
            set { password = value; }
        }

        public float salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public DateTime start_date
        {
            get { return start_date; }
            set { start_date = value; }
        }

        public DateTime end_date
        {
            get { return end_date; }
            set { end_date = value; }
        }

        public Role role
        {
            get { return role; }
            set { role = value; }
        }

        public String toString()
        {
            return this.lastname + " | " + this.firstname + " | " + this.role;
        }

    }

    public class Role
    {

    }
}
