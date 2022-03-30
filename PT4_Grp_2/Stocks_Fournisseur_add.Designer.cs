namespace PT4_Grp_2
{
	partial class Stocks_Fournisseur_add
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
            this.name_product = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adddb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_product
            // 
            this.name_product.AutoSize = true;
            this.name_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_product.Location = new System.Drawing.Point(78, 99);
            this.name_product.Name = "name_product";
            this.name_product.Size = new System.Drawing.Size(131, 26);
            this.name_product.TabIndex = 30;
            this.name_product.Text = "Nom produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 26);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nouveau fournisseur";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.add.Location = new System.Drawing.Point(156, 402);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(108, 36);
            this.add.TabIndex = 42;
            this.add.Text = "Ajouter";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 41;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(83, 171);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Fournisseur";
            // 
            // adddb
            // 
            this.adddb.Location = new System.Drawing.Point(210, 169);
            this.adddb.Name = "adddb";
            this.adddb.Size = new System.Drawing.Size(61, 23);
            this.adddb.TabIndex = 45;
            this.adddb.Text = "autre";
            this.adddb.UseVisualStyleBackColor = true;
            this.adddb.Click += new System.EventHandler(this.adddb_Click);
            // 
            // Stocks_Fournisseur_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(297, 450);
            this.Controls.Add(this.adddb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.add);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_product);
            this.Name = "Stocks_Fournisseur_add";
            this.Text = "Stocks_Fournisseur_add";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label name_product;
		private System.Windows.Forms.Label label2;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Button add;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adddb;
    }
}