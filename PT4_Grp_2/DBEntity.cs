using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT4_Grp_2
{
    public class DBEntity
    {
        public DBEntity(int id, OleDbConnection c, string tableName, string codeName)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT " + codeName + " FROM " + tableName + " WHERE " + codeName + " = " + id, c);
        }
    }
}
