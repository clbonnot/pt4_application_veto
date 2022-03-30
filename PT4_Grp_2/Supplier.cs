using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT4_Grp_2
{
    public class Supplier
    {
        int id;
        string name;
        string phone;
        string web;


        public Supplier()
        {

        }

        public Supplier(int i, DB db)
        {
            db.openConnection();
            String[] arg = { i.ToString() };
            OleDbDataReader reader = db.select("select * from fournisseur where code_fournisseur = ?", arg);
            Id = i;
            if (reader.Read())
            {
                Name = reader.GetString(1);
                Phone = reader.GetString(2);
                Web = reader.GetString(3);
        
            }
            db.closeConnection();
        }

        public override string ToString()
        {
            return Name + " | " + Phone + " | " + Web;
        }

        public void Flush(DB db)
        {
            db.openConnection();
            String[] v = { Name, Phone, Web};
            db.nonSelect("insert into fournisseur (nom, telephone, lens_web) values (?,?,?)", v);
            db.closeConnection();
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Web { get => web; set => web = value; }
    
    }
}
