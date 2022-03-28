namespace PT4_Grp_2
{
	partial class Modele_modifier
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
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Delete = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modifier";
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.Honeydew;
            this.progressBar2.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.progressBar2.Location = new System.Drawing.Point(12, 57);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(336, 3);
            this.progressBar2.TabIndex = 26;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Honeydew;
            this.progressBar1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.progressBar1.Location = new System.Drawing.Point(12, 579);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(336, 3);
            this.progressBar1.TabIndex = 27;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.DarkRed;
            this.Delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Delete.Location = new System.Drawing.Point(240, 594);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(108, 36);
            this.Delete.TabIndex = 29;
            this.Delete.Text = "Supprimer";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(12, 594);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(108, 36);
            this.cancel.TabIndex = 28;
            this.cancel.Text = "Annuler";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.update.Location = new System.Drawing.Point(126, 594);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(108, 36);
            this.update.TabIndex = 30;
            this.update.Text = "Modifier";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Modele_modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(360, 642);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.label1);
            this.Name = "Modele_modifier";
            this.Text = "Modele_modifier";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ProgressBar progressBar2;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button cancel;
        public System.Windows.Forms.Button Delete;
        public System.Windows.Forms.Button update;
    }
}