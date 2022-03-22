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

        public DB(String ds, String dbN)
        {
            // Chaîne de connexion (SQL Server local)
            dataSource = ds;
            dbName = dbN;
            
               


        }


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

      
        
        public int insert(string ins, String[] values)
        {
            OleDbCommand cmd = new OleDbCommand(ins, this.dbConnection);
            foreach(String v in values)
                {
                    cmd.Parameters.AddWithValue("?", v);
                }
            

            cmd.ExecuteNonQuery();
            cmd.CommandText = "Select @@Identity";
            int id = Int32.Parse(cmd.ExecuteScalar().ToString());
        
            return id;
        }
        public OleDbConnection getDbConnection() {
            return dbConnection;
        }

        public void openConnection()
        {
            string ChaineBd = "Provider=SQLOLEDB;Data Source=" + dataSource + ";Initial Catalog="
              + dbName + ";Integrated Security=SSPI";
            // Connexion à la base de données
            dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();
        }

        public void closeConnection()
        {
            dbConnection.Close();
        }



    }




}
