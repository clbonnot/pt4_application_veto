using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.OleDb;


namespace PT4_Grp_2.TestUnitaires
{
    internal class Test
    {
        [TestClass]
        public class TestUS2
        {
            Accueil accueil = new Accueil();

            OleDbConnection dbCon;
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-JOYEUX;Initial Catalog=MusiquePT4_E2;Integrated Security=SSPI;";
            List<Albums> albumAbo = new List<Albums>();
            public void InitConnexion()
            {
                dbCon = new OleDbConnection(ChaineBd);
                dbCon.Open();
            }
            [TestMethod]
            public void TestList1EmpruntAbo()
            {
                InitConnexion();
                bool same = true;
                int codeAbo = 0;
                int codeAlbumEmprunter = 515;
                int codeAlbumsGet = 0;
                string titreAlbums = "";
                DateTime dateRetour = new DateTime();
                Client_Inscription client = new Client_Inscription();
                string login = "testUS2";
                string mdp = "US2TestMDP";
                string prenom = "US2TestPrenom";
                string nom = "US2TestNom";
                string nationalite = "France";
                client.AddAbonnes(login, nationalite, nom, mdp, prenom);
                Abonne_Accueil accueilAbo = new Abonne_Accueil(nom, prenom, login);
                string getCode = "SELECT CODE_ABONNÉ FROM ABONNÉS WHERE LOGIN_ABONNÉ ='" + login + "'";
                OleDbCommand cmdCode = new OleDbCommand(getCode, dbCon);
                cmdCode.ExecuteNonQuery();
                OleDbDataReader readCode = cmdCode.ExecuteReader();
                while (readCode.Read())
                {
                    codeAbo = readCode.GetInt32(0);
                }
                readCode.Close();

            }
        }
