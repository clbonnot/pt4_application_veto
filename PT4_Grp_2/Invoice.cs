using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT4_Grp_2
{
    class Invoice
    {
        Client client;
        Staff staff;
        string date;
        Dictionary<Product, int> products;


        /**
         * Basic constructor
         */
        public Invoice()
        {

        }

        /**
         * Constructor of an invoice which create it in the database
         * 
         * @Param id the id of the staff
         * @db the database
         */
        public Invoice(int id, DB db)
        {
            db.openConnection();
            String[] arg = { id.ToString() };
            OleDbDataReader reader = db.select("select * from facture where code_facture = ?", arg);
            if (reader.Read())
            {
                //TODO
            }
        }
    }
}
