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
            this.stock = new System.Windows.Forms.Button();
            this.panier = new System.Windows.Forms.Button();
            this.stats = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.Button();
            this.logs = new System.Windows.Forms.Button();
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
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(3, 135);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(107, 27);
            this.stock.TabIndex = 65;
            this.stock.Text = "Stocks";
            this.stock.UseVisualStyleBackColor = true;
            this.stock.Click += new System.EventHandler(this.stock_Click);
            // 
            // panier
            // 
            this.panier.AllowDrop = true;
            this.panier.Location = new System.Drawing.Point(3, 168);
            this.panier.Name = "panier";
            this.panier.Size = new System.Drawing.Size(107, 27);
            this.panier.TabIndex = 66;
            this.panier.Text = "Panier";
            this.panier.UseVisualStyleBackColor = true;
            this.panier.Click += new System.EventHandler(this.panier_Click);
            // 
            // stats
            // 
            this.stats.AllowDrop = true;
            this.stats.Location = new System.Drawing.Point(3, 201);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(107, 27);
            this.stats.TabIndex = 67;
            this.stats.Text = "Statistiques";
            this.stats.UseVisualStyleBackColor = true;
            this.stats.Click += new System.EventHandler(this.stats_Click);
            // 
            // admin
            // 
            this.admin.AllowDrop = true;
            this.admin.Location = new System.Drawing.Point(3, 233);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(107, 27);
            this.admin.TabIndex = 68;
            this.admin.Text = "Administrateur";
            this.admin.UseVisualStyleBackColor = true;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // logs
            // 
            this.logs.AllowDrop = true;
            this.logs.Location = new System.Drawing.Point(3, 266);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(107, 27);
            this.logs.TabIndex = 69;
            this.logs.Text = "Logs";
            this.logs.UseVisualStyleBackColor = true;
            this.logs.Click += new System.EventHandler(this.logs_Click);
            // 
            // Control_veto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Controls.Add(this.logs);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.stats);
            this.Controls.Add(this.panier);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.client);
            this.Controls.Add(this.maladie);
            this.Controls.Add(this.soin);
            this.Controls.Add(this.Calendrier);
            this.Name = "Control_veto";
            this.Size = new System.Drawing.Size(115, 297);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button maladie;
		private System.Windows.Forms.Button soin;
		private System.Windows.Forms.Button Calendrier;
		private System.Windows.Forms.Button client;
        private System.Windows.Forms.Button stock;
        private System.Windows.Forms.Button panier;
        private System.Windows.Forms.Button stats;
        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Button logs;
    }
}
