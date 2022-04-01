namespace PT4_Grp_2
{
	partial class Calendrier_add_conge
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
            this.add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.nbJours = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.listPersonnel = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.add.Location = new System.Drawing.Point(285, 322);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(108, 36);
            this.add.TabIndex = 35;
            this.add.Text = "Ajouter";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 34;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Honeydew;
            this.progressBar1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.progressBar1.Location = new System.Drawing.Point(57, 307);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(336, 3);
            this.progressBar1.TabIndex = 33;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.Honeydew;
            this.progressBar2.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.progressBar2.Location = new System.Drawing.Point(57, 41);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(336, 3);
            this.progressBar2.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 31);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ajouter un congé";
            // 
            // nbJours
            // 
            this.nbJours.AutoSize = true;
            this.nbJours.Location = new System.Drawing.Point(67, 281);
            this.nbJours.Name = "nbJours";
            this.nbJours.Size = new System.Drawing.Size(76, 13);
            this.nbJours.TabIndex = 44;
            this.nbJours.Text = "nbJours totaux";
            this.nbJours.Click += new System.EventHandler(this.nbJours_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Date de début";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Date de fin";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Personnel sélectionné";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(57, 218);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 20);
            this.dateEnd.TabIndex = 39;
            this.dateEnd.ValueChanged += new System.EventHandler(this.dateEnd_ValueChanged);
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(57, 156);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 20);
            this.dateStart.TabIndex = 38;
            // 
            // listPersonnel
            // 
            this.listPersonnel.FormattingEnabled = true;
            this.listPersonnel.Location = new System.Drawing.Point(285, 59);
            this.listPersonnel.Name = "listPersonnel";
            this.listPersonnel.Size = new System.Drawing.Size(145, 199);
            this.listPersonnel.TabIndex = 92;
            this.listPersonnel.SelectedIndexChanged += new System.EventHandler(this.listPersonnel_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 93;
            // 
            // Calendrier_add_conge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(456, 386);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listPersonnel);
            this.Controls.Add(this.nbJours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.add);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.label1);
            this.Name = "Calendrier_add_conge";
            this.Text = "Calendrier_add_conge";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button add;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.ProgressBar progressBar2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label nbJours;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateEnd;
		private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.ListBox listPersonnel;
        private System.Windows.Forms.Label label3;
    }
}