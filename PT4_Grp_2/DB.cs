using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT4_Grp_2
{
    internal class DB
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
