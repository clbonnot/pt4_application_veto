namespace PT4_Grp_2
{
	partial class Control_secretaire
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
			this.stats = new System.Windows.Forms.Button();
			this.client = new System.Windows.Forms.Button();
			this.shop = new System.Windows.Forms.Button();
			this.stock = new System.Windows.Forms.Button();
			this.Calendrier = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// stats
			// 
			this.stats.Location = new System.Drawing.Point(3, 135);
			this.stats.Name = "stats";
			this.stats.Size = new System.Drawing.Size(107, 27);
			this.stats.TabIndex = 70;
			this.stats.Text = "Statistiques";
			this.stats.UseVisualStyleBackColor = true;
			this.stats.Click += new System.EventHandler(this.stats_Click);
			// 
			// client
			// 
			this.client.Location = new System.Drawing.Point(3, 102);
			this.client.Name = "client";
			this.client.Size = new System.Drawing.Size(107, 27);
			this.client.TabIndex = 69;
			this.client.Text = "Clients";
			this.client.UseVisualStyleBackColor = true;
			this.client.Click += new System.EventHandler(this.client_Click);
			// 
			// shop
			// 
			this.shop.Enabled = false;
			this.shop.Location = new System.Drawing.Point(3, 69);
			this.shop.Name = "shop";
			this.shop.Size = new System.Drawing.Size(107, 27);
			this.shop.TabIndex = 68;
			this.shop.Text = "Panier";
			this.shop.UseVisualStyleBackColor = true;
			this.shop.Click += new System.EventHandler(this.shop_Click);
			// 
			// stock
			// 
			this.stock.Location = new System.Drawing.Point(3, 36);
			this.stock.Name = "stock";
			this.stock.Size = new System.Drawing.Size(107, 27);
			this.stock.TabIndex = 67;
			this.stock.Text = "Stocks";
			this.stock.UseVisualStyleBackColor = true;
			this.stock.Click += new System.EventHandler(this.stock_Click);
			// 
			// Calendrier
			// 
			this.Calendrier.Location = new System.Drawing.Point(3, 3);
			this.Calendrier.Name = "Calendrier";
			this.Calendrier.Size = new System.Drawing.Size(107, 27);
			this.Calendrier.TabIndex = 66;
			this.Calendrier.Text = "Calendrier";
			this.Calendrier.UseVisualStyleBackColor = true;
			this.Calendrier.Click += new System.EventHandler(this.Calendrier_Click);
			// 
			// Control_secretaire
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumAquamarine;
			this.Controls.Add(this.stats);
			this.Controls.Add(this.client);
			this.Controls.Add(this.shop);
			this.Controls.Add(this.stock);
			this.Controls.Add(this.Calendrier);
			this.Name = "Control_secretaire";
			this.Size = new System.Drawing.Size(114, 169);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button stats;
		private System.Windows.Forms.Button client;
		private System.Windows.Forms.Button shop;
		private System.Windows.Forms.Button stock;
		private System.Windows.Forms.Button Calendrier;
	}
}
