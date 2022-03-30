using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT4_Grp_2
{
    public class Client : People
    {
        /**
         * Basic constructor
         */
        public Client()
        {
            animals = new List<Animal>();
        }

        /**
       * Constructor of a client, which create it from the database.
       * 
       * @param id the id of the client in the database
       * @param db the database
       */
        public Client(int id, DB db)
        {
            db.openConnection();
            String[] v = { id.ToString() };
            OleDbDataReader reader = db.select("select * from personne where code_personne = ?", v);
            if (reader.Read())
            {
                Id = id;
                Lastname = reader.GetString(1);
                Firstname = reader.GetString(2);
                Mail = reader.GetString(3);
                Phone = reader.GetString(4);
            }
            animals = new List<Animal>();
            OleDbDataReader readerAnimals = db.select("select code_animal from animal where code_personne = ? order by nom_animal asc", v);
            
            while (readerAnimals.Read())
            {
               animals.Add(new Animal(readerAnimals.GetInt32(0), db, this));
      
            }
      
            db.closeConnection();

        }

        /**
        * Function that add the current instance in the database
         * 
         * @Param db the database
        */
        public void Flush(DB db)
        {
            db.openConnection();
            String[] v = { Lastname, Firstname, Mail, Phone };
            db.nonSelect("INSERT INTO Personne (NOM,PRENOM,MAIL,TELEPHONE) values (?,?,?,?)", v);
            db.closeConnection();
        }

        /**
         * Function that delete the current instance in the database
         * 
         * @Param db the database
         */
        public void Delete(DB db)
        {
            db.openConnection();
            String[] v = { this.Id.ToString() };
            db.nonSelect("delete from personne where code_personne = ?", v);
            db.nonSelect("delete from animal where code_personne = ?",v);
            db.closeConnection();
        }


        /**
         * Function that update the current instance of the client with the attribute of an another client. It also update it in the database.
         * 
         * @Param db the database
         * @Param a the another client
         */
        public void Update(DB db, Client c)
        {
            String[] v = { c.Lastname, c.Firstname, c.Mail, c.Phone, this.Id.ToString() };
            db.openConnection();
            db.nonSelect("update personne " +
                "set nom = ?," +
                "prenom = ?," +
                "mail = ?," +
                "telephone = ? " +
                "where code_personne = ?", v);
            Lastname = c.Lastname;
            Firstname = c.Firstname;
            Mail = c.Mail;
            Phone = c.Phone;
            db.closeConnection();
        }

        /**
         * Function that convert the instance to a String.
         */
        public override String ToString()
        {
            return this.Lastname + " | " + this.Firstname;
        }

        private List<Animal> animals;

        public List<Animal> Animals { get => animals; set => animals = value; }
    }
}
