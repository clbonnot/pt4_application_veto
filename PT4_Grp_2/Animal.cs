using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT4_Grp_2
{
    public class Animal 
    {

        
        /**
         * Constructor of an animal, which create it from the database.
         * 
         * @param id the id of the animal in the database
         * @param db the database
         */
        public Animal(int id, DB DBCon, Client p)
        {
         
            DBCon.openConnection();
            String[] v = { id.ToString() };
            OleDbDataReader reader = DBCon.select("select * from animal where code_animal = ?", v);
            if (reader.Read())
            {
                Id = id;
                Name = reader.GetString(1);
                try
                {
                    Date_birth = reader.GetString(2);
                }
                catch
                {
                    Date_birth = "uknown";
                }
                Mass = (float)reader.GetDecimal(3);
                Sex = reader.GetString(4);
                Note = reader.GetString(5);
                Idrace = reader.GetInt32(6);
                Owner = p;

                String[] v2 = { Idrace.ToString() };
                OleDbDataReader readerRace = DBCon.select("select Code_Espèce from race where code_race = ?", v2);
                if (readerRace.Read())
                {
                    Idtype = readerRace.GetInt32(0);
                }
            }
            DBCon.closeConnection();
        }

        

        /**
         * Basic constructor of the class
         * 
         */
        public Animal()
        {

        }

        
        /**
         * Function that add the current instance in the database
         * 
         * @Param db the database
         */
        public void Flush(DB db)
        {
            String[] values = { name, date_birth, mass.ToString(), sex, note, Idrace.ToString(), Owner.Id.ToString() };
            db.openConnection();
            db.nonSelect("insert into animal (nom_animal,date_naissance,poids,sexe,note,code_race,code_personne) values (?,?,?,?,?,?,?)", values);
            db.closeConnection();


        }

        /**
         * Function that update the current instance of the animal with the attribute of an another animal. It also update it in the database.
         * 
         * @Param db the database
         * @Param a the another animal
         */
        public void update(DB db, Animal a)
        {
            String[] values = { a.name, a.date_birth, a.mass.ToString(), a.sex, a.note, a.Idrace.ToString(), a.Owner.Id.ToString() , this.Id.ToString()};
            db.openConnection();
            db.nonSelect("update Animal " +
                "Set Nom_Animal = ?, " +
                "Date_Naissance = ?, " +
                "Poids = ?," +
                "sexe = ?," +
                "Note = ?," +
                "Code_Race = ?," +
                "Code_Personne = ? " +
                "where Code_Animal = ?", values);
            db.closeConnection();
            
            Name = a.Name;
            Date_birth = a.Date_birth;
            Mass = a.Mass;
            Sex = a.Sex;
            Note = a.Note;
            Idrace = a.Idrace;
            Idtype = a.Idtype;
            Owner = a.Owner;
           
        }

        /**
         * Function that delete the current instance in the database.
         * 
         * @Param db the database.
         */
        public void delete(DB db)
        {
            db.openConnection();
            String[] v = { Id.ToString() };
            db.nonSelect("delete from animal where code_animal = ? ", v);
            db.closeConnection();
            Owner.Animals.Remove(this);
            
        }

        #region forLater
        public static String[] raceInfo(int Idrace, DB DBCon)
        {
            String[] infos = new string[2];
            DBCon.openConnection();
            String[] v = { Idrace.ToString() };
            OleDbDataReader reader = DBCon.select("select nomRace, descrip from race where code_race = ?", v);
            if (reader.Read())
            {
                infos[0] = reader.GetString(0);
                infos[1] = reader.GetString(1);
            }
            DBCon.closeConnection();
            return infos;
        }
        public static String[] typeInfo(int Idtype, DB DBCon)
        {
            String[] infos = new string[2];
            DBCon.openConnection();
            String[] v = { Idtype.ToString() };
            OleDbDataReader reader = DBCon.select("select nomEspèce, descrip from espèce where code_espèce = ?", v);
            if (reader.Read())
            {
                infos[0] = reader.GetString(0);
                infos[1] = reader.GetString(1);
            }
            DBCon.closeConnection();
            return infos;
        }
        #endregion

        /**
         * Function that return the informations of a race.
         * 
         * @param db the database
         * @return a string that contains in it first index the name of the race and in it second the description of it
         */
        public String[] raceInfo(DB DBCon)
        {
            String[] infos = new string[2];
            DBCon.openConnection();
            String[] v = { Idrace.ToString() };
            OleDbDataReader reader = DBCon.select("select nomRace, descrip from race where code_race = ?", v);
            if (reader.Read())
            {
                infos[0] = reader.GetString(0);
                infos[1] = reader.GetString(1);
            }
            DBCon.closeConnection();
            return infos;
        }

        /**
         * Function that return the informations of a type (species) of animal.
         * 
         * @param db the database
         * @return a string that contains in it first index the name and in it second the description of it
         **/
        public String[] typeInfo(DB DBCon)
        {
            String[] infos = new string[2];
            DBCon.openConnection();
            String[] v = { Idtype.ToString() };
            OleDbDataReader reader = DBCon.select("select nomEspèce, descrip from espèce where code_espèce = ?", v);
            if (reader.Read())
            {
                infos[0] = reader.GetString(0);
                infos[1] = reader.GetString(1);
            }
            DBCon.closeConnection();
            return infos;
        }

        public String ToString(DB db)
        {
           
            return Name + " | " + typeInfo(db)[0] + " | " + raceInfo(db)[0];
        }
        private int id;
        private string name;
        private string date_birth;
        private float mass;
        private string sex;
        private string note;

        private int idrace;
        
        private int idtype;
        private Client owner;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Date_birth { get => date_birth; set => date_birth = value; }
        public float Mass { get => mass; set => mass = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Note { get => note; set => note = value; }

        public int Idrace { get => idrace; set => idrace = value; }
       
        internal Client Owner { get => owner; set => owner = value; }
      
        public int Idtype { get => idtype; set => idtype = value; }
    }
}
