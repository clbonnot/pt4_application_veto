namespace PT4_Grp_2
{
	partial class Paniers
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
            this.validate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listArticles = new System.Windows.Forms.ListBox();
            this.name = new System.Windows.Forms.Label();
            this.plus_buy = new System.Windows.Forms.Button();
            this.minus_buy = new System.Windows.Forms.Button();
            this.products = new System.Windows.Forms.ComboBox();
            this.total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.client = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Deconnexion
            // 
            this.Deconnexion.FlatAppearance.BorderSize = 0;
            // 
            // validate
            // 
            this.validate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.validate.Location = new System.Drawing.Point(672, 402);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(108, 36);
            this.validate.TabIndex = 34;
            this.validate.Text = "Valider";
            this.validate.UseVisualStyleBackColor = false;
            this.validate.Click += new System.EventHandler(this.validate_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.DarkRed;
            this.clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clear.Location = new System.Drawing.Point(169, 402);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(108, 36);
            this.clear.TabIndex = 33;
            this.clear.Text = "Vider";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(576, 275);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(108, 36);
            this.remove.TabIndex = 32;
            this.remove.Text = "Supprimer";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Honeydew;
            this.progressBar1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.progressBar1.Location = new System.Drawing.Point(169, 380);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(611, 3);
            this.progressBar1.TabIndex = 31;
            // 
            // listArticles
            // 
            this.listArticles.FormattingEnabled = true;
            this.listArticles.Location = new System.Drawing.Point(169, 62);
            this.listArticles.Name = "listArticles";
            this.listArticles.Size = new System.Drawing.Size(611, 212);
            this.listArticles.TabIndex = 35;
            this.listArticles.DoubleClick += new System.EventHandler(this.listArticles_DoubleClick);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(169, 294);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(60, 17);
            this.name.TabIndex = 36;
            this.name.Text = "Total : ";
            // 
            // plus_buy
            // 
            this.plus_buy.Location = new System.Drawing.Point(15, 110);
            this.plus_buy.Name = "plus_buy";
            this.plus_buy.Size = new System.Drawing.Size(108, 33);
            this.plus_buy.TabIndex = 47;
            this.plus_buy.Text = "+";
            this.plus_buy.UseVisualStyleBackColor = true;
            this.plus_buy.Click += new System.EventHandler(this.plus_buy_Click);
            // 
            // minus_buy
            // 
            this.minus_buy.Location = new System.Drawing.Point(15, 71);
            this.minus_buy.Name = "minus_buy";
            this.minus_buy.Size = new System.Drawing.Size(108, 33);
            this.minus_buy.TabIndex = 46;
            this.minus_buy.Text = "-";
            this.minus_buy.UseVisualStyleBackColor = true;
            this.minus_buy.Click += new System.EventHandler(this.minus_buy_Click);
            // 
            // products
            // 
            this.products.FormattingEnabled = true;
            this.products.Location = new System.Drawing.Point(394, 275);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(121, 21);
            this.products.TabIndex = 48;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(235, 298);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(13, 13);
            this.total.TabIndex = 50;
            this.total.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "euros";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(394, 302);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(108, 36);
            this.add.TabIndex = 52;
            this.add.Text = "Ajouter";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // client
            // 
            this.client.FormattingEnabled = true;
            this.client.Location = new System.Drawing.Point(507, 411);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(159, 21);
            this.client.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Client (facultatif)";
            // 
            // Paniers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.client);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.total);
            this.Controls.Add(this.products);
            this.Controls.Add(this.plus_buy);
            this.Controls.Add(this.minus_buy);
            this.Controls.Add(this.name);
            this.Controls.Add(this.listArticles);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.progressBar1);
            this.Name = "Paniers";
            this.Text = "Paniers";
            this.Controls.SetChildIndex(this.RoleName, 0);
            this.Controls.SetChildIndex(this.Deconnexion, 0);
            this.Controls.SetChildIndex(this.progressBar1, 0);
            this.Controls.SetChildIndex(this.remove, 0);
            this.Controls.SetChildIndex(this.clear, 0);
            this.Controls.SetChildIndex(this.validate, 0);
            this.Controls.SetChildIndex(this.listArticles, 0);
            this.Controls.SetChildIndex(this.name, 0);
            this.Controls.SetChildIndex(this.minus_buy, 0);
            this.Controls.SetChildIndex(this.plus_buy, 0);
            this.Controls.SetChildIndex(this.products, 0);
            this.Controls.SetChildIndex(this.total, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.add, 0);
            this.Controls.SetChildIndex(this.client, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button validate;
		private System.Windows.Forms.Button clear;
		private System.Windows.Forms.Button remove;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label name;
		private System.Windows.Forms.Button plus_buy;
		private System.Windows.Forms.Button minus_buy;
		public System.Windows.Forms.ListBox listArticles;
        private System.Windows.Forms.ComboBox products;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ComboBox client;
        private System.Windows.Forms.Label label1;
    }
}