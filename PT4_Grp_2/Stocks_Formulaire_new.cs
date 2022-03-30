﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT4_Grp_2
{
    public partial class Stocks_Formulaire_new : Form
    {
        DB db;
        public Stocks_Formulaire_new(DB db)
        {
            InitializeComponent();
            this.db = db;
        }

   

        private void add_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            s.Name = name.Text;
            s.Phone = phone.Text;
            s.Web = web.Text;
            try
            {
                s.Flush(db);
                MessageBox.Show("Fournisseur ajouté à la base de données avec succés ! ");
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Erreur lors de l'ajout du fournisseur. Vérifiez que vous avez renseigné tout les champs. Message d'erreur : " + exc);
            }
        }
    }
}
