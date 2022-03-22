namespace PT4_Grp_2
{
	partial class Control_veto
	{
		/// <summary> 
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur de composants

		/// <summary> 
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.maladie = new System.Windows.Forms.Button();
			this.soin = new System.Windows.Forms.Button();
			this.Calendrier = new System.Windows.Forms.Button();
			this.client = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// maladie
			// 
			this.maladie.Enabled = false;
			this.maladie.Location = new System.Drawing.Point(3, 69);
			this.maladie.Name = "maladie";
			this.maladie.Size = new System.Drawing.Size(107, 27);
			this.maladie.TabIndex = 63;
			this.maladie.Text = "Maladies";
			this.maladie.UseVisualStyleBackColor = true;
			this.maladie.Click += new System.EventHandler(this.maladie_Click);
			// 
			// soin
			// 
			this.soin.Location = new System.Drawing.Point(3, 36);
			this.soin.Name = "soin";
			this.soin.Size = new System.Drawing.Size(107, 27);
			this.soin.TabIndex = 62;
			this.soin.Text = "Soins";
			this.soin.UseVisualStyleBackColor = true;
			this.soin.Click += new System.EventHandler(this.soin_Click);
			// 
			// Calendrier
			// 
			this.Calendrier.Location = new System.Drawing.Point(3, 3);
			this.Calendrier.Name = "Calendrier";
			this.Calendrier.Size = new System.Drawing.Size(107, 27);
			this.Calendrier.TabIndex = 61;
			this.Calendrier.Text = "Calendrier";
			this.Calendrier.UseVisualStyleBackColor = true;
			this.Calendrier.Click += new System.EventHandler(this.Calendrier_Click);
			// 
			// client
			// 
			this.client.Location = new System.Drawing.Point(3, 102);
			this.client.Name = "client";
			this.client.Size = new System.Drawing.Size(107, 27);
			this.client.TabIndex = 64;
			this.client.Text = "Clients";
			this.client.UseVisualStyleBackColor = true;
			this.client.Click += new System.EventHandler(this.client_Click);
			// 
			// Control_veto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumAquamarine;
			this.Controls.Add(this.client);
			this.Controls.Add(this.maladie);
			this.Controls.Add(this.soin);
			this.Controls.Add(this.Calendrier);
			this.Name = "Control_veto";
			this.Size = new System.Drawing.Size(115, 137);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button maladie;
		private System.Windows.Forms.Button soin;
		private System.Windows.Forms.Button Calendrier;
		private System.Windows.Forms.Button client;
	}
}
