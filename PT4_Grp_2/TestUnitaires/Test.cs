using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.OleDb;


namespace PT4_Grp_2.TestUnitaires
{

    [TestClass]
    public class TestUnitaires
    {

        OleDbConnection dbCon;
        string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-JOYEUX;Initial Catalog=MusiquePT4_E2;Integrated Security=SSPI;";
        public void InitConnexion()
        {
            dbCon = new OleDbConnection(ChaineBd);
            dbCon.Open();
        }
        // [TestMethod]

    }
}
