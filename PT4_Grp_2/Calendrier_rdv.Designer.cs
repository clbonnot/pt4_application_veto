namespace PT4_Grp_2
{
	partial class Calendrier_rdv
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.date = new System.Windows.Forms.Label();
			this.listRDV = new System.Windows.Forms.ListBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// date
			// 
			this.date.AutoSize = true;
			this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.date.Location = new System.Drawing.Point(325, 63);
			this.date.Name = "date";
			this.date.Size = new System.Drawing.Size(217, 31);
			this.date.TabIndex = 84;
			this.date.Text = "Date selectionée";
			this.date.Click += new System.EventHandler(this.label1_Click);
			// 
			// listRDV
			// 
			this.listRDV.FormattingEnabled = true;
			this.listRDV.Location = new System.Drawing.Point(265, 166);
			this.listRDV.Name = "listRDV";
			this.listRDV.Size = new System.Drawing.Size(145, 199);
			this.listRDV.TabIndex = 83;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.DarkGreen;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label6.Location = new System.Drawing.Point(322, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(220, 31);
			this.label6.TabIndex = 85;
			this.label6.Text = "Calendrier - RDV";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.label1.Location = new System.Drawing.Point(262, 130);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 17);
			this.label1.TabIndex = 86;
			this.label1.Text = "Liste des rendez-vous";
			this.label1.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// Calendrier_rdv
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.date);
			this.Controls.Add(this.listRDV);
			this.Name = "Calendrier_rdv";
			this.Text = "Calendrier_rdv";
			this.Controls.SetChildIndex(this.listRDV, 0);
			this.Controls.SetChildIndex(this.date, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label date;
		private System.Windows.Forms.ListBox listRDV;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label1;
	}
}