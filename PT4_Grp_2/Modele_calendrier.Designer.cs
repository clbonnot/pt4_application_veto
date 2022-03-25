namespace PT4_Grp_2
{
	partial class Modele_calendrier
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
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.label6 = new System.Windows.Forms.Label();
			this.progressBar2 = new System.Windows.Forms.ProgressBar();
			this.update = new System.Windows.Forms.Button();
			this.add = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(529, 169);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.DarkGreen;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label6.Location = new System.Drawing.Point(358, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(139, 31);
			this.label6.TabIndex = 77;
			this.label6.Text = "Calendrier";
			// 
			// progressBar2
			// 
			this.progressBar2.BackColor = System.Drawing.Color.Honeydew;
			this.progressBar2.ForeColor = System.Drawing.Color.DarkSeaGreen;
			this.progressBar2.Location = new System.Drawing.Point(11, 133);
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new System.Drawing.Size(129, 3);
			this.progressBar2.TabIndex = 80;
			// 
			// update
			// 
			this.update.Location = new System.Drawing.Point(21, 100);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(107, 27);
			this.update.TabIndex = 79;
			this.update.Text = "MODIFIER";
			this.update.UseVisualStyleBackColor = true;
			this.update.Visible = false;
			// 
			// add
			// 
			this.add.Location = new System.Drawing.Point(21, 67);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(107, 27);
			this.add.TabIndex = 78;
			this.add.Text = "AJOUTER";
			this.add.UseVisualStyleBackColor = true;
			// 
			// Modele_calendrier
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.progressBar2);
			this.Controls.Add(this.update);
			this.Controls.Add(this.add);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.monthCalendar1);
			this.Name = "Modele_calendrier";
			this.Text = "Modele_calendrier";
			this.Controls.SetChildIndex(this.monthCalendar1, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.Controls.SetChildIndex(this.add, 0);
			this.Controls.SetChildIndex(this.update, 0);
			this.Controls.SetChildIndex(this.progressBar2, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ProgressBar progressBar2;
		public System.Windows.Forms.MonthCalendar monthCalendar1;
		public System.Windows.Forms.Button update;
		public System.Windows.Forms.Button add;
	}
}