namespace PT4_Grp_2
{
    partial class Maladies
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maladies));
			this.Deconnexion = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.stats = new System.Windows.Forms.Button();
			this.client = new System.Windows.Forms.Button();
			this.maladie = new System.Windows.Forms.Button();
			this.soin = new System.Windows.Forms.Button();
			this.Calendrier = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Deconnexion
			// 
			this.Deconnexion.FlatAppearance.BorderSize = 0;
			this.Deconnexion.Location = new System.Drawing.Point(692, 12);
			this.Deconnexion.Name = "Deconnexion";
			this.Deconnexion.Size = new System.Drawing.Size(81, 24);
			this.Deconnexion.TabIndex = 30;
			this.Deconnexion.Text = "Deconnexion";
			this.Deconnexion.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(288, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(223, 36);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 42;
			this.pictureBox1.TabStop = false;
			// 
			// stats
			// 
			this.stats.Location = new System.Drawing.Point(22, 277);
			this.stats.Name = "stats";
			this.stats.Size = new System.Drawing.Size(107, 27);
			this.stats.TabIndex = 65;
			this.stats.Text = "Statistiques";
			this.stats.UseVisualStyleBackColor = true;
			// 
			// client
			// 
			this.client.Location = new System.Drawing.Point(22, 244);
			this.client.Name = "client";
			this.client.Size = new System.Drawing.Size(107, 27);
			this.client.TabIndex = 64;
			this.client.Text = "Clients";
			this.client.UseVisualStyleBackColor = true;
			// 
			// maladie
			// 
			this.maladie.Enabled = false;
			this.maladie.Location = new System.Drawing.Point(22, 211);
			this.maladie.Name = "maladie";
			this.maladie.Size = new System.Drawing.Size(107, 27);
			this.maladie.TabIndex = 63;
			this.maladie.Text = "Maladies";
			this.maladie.UseVisualStyleBackColor = true;
			// 
			// soin
			// 
			this.soin.Location = new System.Drawing.Point(22, 178);
			this.soin.Name = "soin";
			this.soin.Size = new System.Drawing.Size(107, 27);
			this.soin.TabIndex = 62;
			this.soin.Text = "Soins";
			this.soin.UseVisualStyleBackColor = true;
			// 
			// Calendrier
			// 
			this.Calendrier.Location = new System.Drawing.Point(22, 145);
			this.Calendrier.Name = "Calendrier";
			this.Calendrier.Size = new System.Drawing.Size(107, 27);
			this.Calendrier.TabIndex = 61;
			this.Calendrier.Text = "Calendrier";
			this.Calendrier.UseVisualStyleBackColor = true;
			// 
			// Maladies
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.stats);
			this.Controls.Add(this.client);
			this.Controls.Add(this.maladie);
			this.Controls.Add(this.soin);
			this.Controls.Add(this.Calendrier);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.Deconnexion);
			this.Name = "Maladies";
			this.Text = "Maladies";
			this.Controls.SetChildIndex(this.Deconnexion, 0);
			this.Controls.SetChildIndex(this.pictureBox1, 0);
			this.Controls.SetChildIndex(this.Calendrier, 0);
			this.Controls.SetChildIndex(this.soin, 0);
			this.Controls.SetChildIndex(this.maladie, 0);
			this.Controls.SetChildIndex(this.client, 0);
			this.Controls.SetChildIndex(this.stats, 0);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button Deconnexion;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button stats;
		private System.Windows.Forms.Button client;
		private System.Windows.Forms.Button maladie;
		private System.Windows.Forms.Button soin;
		private System.Windows.Forms.Button Calendrier;
	}
}