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
	public partial class Modele_modifier : Form
	{
		public Modele_modifier()
		{
			InitializeComponent();
		}

        private void cancel_Click(object sender, EventArgs e)
        {
			Close();
        }

        public virtual void update_Click(object sender, EventArgs e)
        {

        }

        public virtual void Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
