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
        public Animal(int id, OleDbConnection c)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT Code_Animal FROM Animal WHERE Code_Animal = " + id, c);
        }
        public int id
        {
            get { return id; }
            set { id = value; }
        }
        public string name
        {
            get { return name; }
            set { name = value; }
        }

        public string mass
        {
            get { return mass; }
            set { mass = value; }
        }

        public string sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public string note
        {
            get { return note; }
            set { string note = value; }
        }
    /**    public Race race
        {
            get { return race; }
            set { race = value; }
        }

        public People owner
        {
            get { return owner; }
            set { owner = value; }
        }
    **/

    }
}
