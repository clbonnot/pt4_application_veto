using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT4_Grp_2
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
            Console.WriteLine("eho");
            DB dTest = new DB("INFO-JOYEUX", "PT4_E2");
            dTest.openConnection();
            OleDbCommand cmd = new OleDbCommand("SELECT Code_Animal FROM Animal WHERE Code_Animal = 2", dTest.getDbConnection());
            OleDbDataReader r = cmd.ExecuteReader();
            
            while (r.Read())
            {
                Console.WriteLine("eho 5 ");
                Console.WriteLine(r.GetString(1));   
            }
            dTest.closeConnection();
        }
    }
}
