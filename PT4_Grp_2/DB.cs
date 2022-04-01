using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PT4_Grp_2
{
    public class DB
    {

        public OleDbConnection dbConnection;
        String dataSource;
        String dbName;

        /**
         * Constructor of the class
         * 
         * ds the data source
         * dbN the name of the database
         */
        public DB(String ds, String dbN)
        {
            // Chaîne de connexion (SQL Server local)
            dataSource = ds;
            dbName = dbN;




            return cmd.ExecuteReader();
        }

        /**
         * Function that execute a select request
         * 
         * @param request the request 
         * @param args the parameters of the request (can be null)
         * @return a OleDbDataReader that contains the results of the request
         */
        public OleDbDataReader select(String request, String[] args)
        {

            OleDbCommand cmd = new OleDbCommand(request, this.dbConnection);
            if (args != null)
            {
                foreach (String arg in args)
                {
                    cmd.Parameters.AddWithValue("?", arg);
                }
            }


            return cmd.ExecuteReader();
        }

   


        /**
         * Function that execute a non select request
         * 
         * @param request the request
         * @param values the values of the request
         */ 
        public void nonSelect(string request, String[] values)
        {
            OleDbCommand cmd = new OleDbCommand(request, this.dbConnection);
            foreach (String v in values)
            {
                cmd.Parameters.AddWithValue("?", v);
            }


            cmd.ExecuteNonQuery();
        }

        /**
         * Same function as nonSelect, except that it returns an id.
         * 
         * @param ins the request
         * @param values the values of the request
         * @return an int who correspond to the id of the last inserted value in the database
         */
        public int insert(string ins, String[] values)
        {
            OleDbCommand cmd = new OleDbCommand(ins, this.dbConnection);
            foreach (String v in values)
            {
                cmd.Parameters.AddWithValue("?", v);
            }


            cmd.ExecuteNonQuery();
            cmd.CommandText = "Select @@Identity";
            int id = Int32.Parse(cmd.ExecuteScalar().ToString());

            return id;
        }
   
        /**
         * Function that open the connection of the database 
         */
        public void openConnection()
        {
            string ChaineBd = "Provider=SQLOLEDB;Data Source=" + dataSource + ";Initial Catalog="
              + dbName + ";Integrated Security=SSPI";
            // Connexion à la base de données
            dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();
        }

        /**
         * Function that close the connection of the database
         */
        public void closeConnection()
        {
            dbConnection.Close();
        }

    }

}

