namespace PT4_Grp_2
{
	partial class Stocks_detail
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
            this.label_buy = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.actual_stock = new System.Windows.Forms.Label();
            this.minus_buy = new System.Windows.Forms.Button();
            this.plus_buy = new System.Windows.Forms.Button();
            this.quantity_buy = new System.Windows.Forms.TextBox();
            this.validateBuy = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.back_page = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listSupplier = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.price_u = new System.Windows.Forms.Label();
            this.addSup = new System.Windows.Forms.Button();
            this.validateP = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.brand = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Deconnexion
            // 
            this.Deconnexion.FlatAppearance.BorderSize = 0;
            // 
            // name_product
            // 
            this.name_product.AutoSize = true;
            this.name_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_product.Location = new System.Drawing.Point(180, 74);
            this.name_product.Name = "name_product";
            this.name_product.Size = new System.Drawing.Size(131, 26);
            this.name_product.TabIndex = 12;
            this.name_product.Text = "Nom produit";
            // 
            // label_buy
            // 
            this.label_buy.AutoSize = true;
            this.label_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buy.Location = new System.Drawing.Point(180, 408);
            this.label_buy.Name = "label_buy";
            this.label_buy.Size = new System.Drawing.Size(115, 24);
            this.label_buy.TabIndex = 13;
            this.label_buy.Text = "Commander";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(182, 300);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(79, 17);
            this.description.TabIndex = 14;
            this.description.Text = "Description";
            // 
            // actual_stock
            // 
            this.actual_stock.AutoSize = true;
            this.actual_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actual_stock.Location = new System.Drawing.Point(181, 111);
            this.actual_stock.Name = "actual_stock";
            this.actual_stock.Size = new System.Drawing.Size(71, 20);
            this.actual_stock.TabIndex = 15;
            this.actual_stock.Text = "En stock";
            // 
            // minus_buy
            // 
            this.minus_buy.Location = new System.Drawing.Point(324, 406);
            this.minus_buy.Name = "minus_buy";
            this.minus_buy.Size = new System.Drawing.Size(38, 33);
            this.minus_buy.TabIndex = 17;
            this.minus_buy.Text = "-";
            this.minus_buy.UseVisualStyleBackColor = true;
            // 
            // plus_buy
            // 
            this.plus_buy.Location = new System.Drawing.Point(414, 406);
            this.plus_buy.Name = "plus_buy";
            this.plus_buy.Size = new System.Drawing.Size(38, 33);
            this.plus_buy.TabIndex = 18;
            this.plus_buy.Text = "+";
            this.plus_buy.UseVisualStyleBackColor = true;
            // 
            // quantity_buy
            // 
            this.quantity_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_buy.Location = new System.Drawing.Point(369, 408);
            this.quantity_buy.Name = "quantity_buy";
            this.quantity_buy.Size = new System.Drawing.Size(39, 30);
            this.quantity_buy.TabIndex = 19;
            this.quantity_buy.Text = "0";
            this.quantity_buy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // validateBuy
            // 
            this.validateBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateBuy.Location = new System.Drawing.Point(481, 406);
            this.validateBuy.Name = "validateBuy";
            this.validateBuy.Size = new System.Drawing.Size(76, 32);
            this.validateBuy.TabIndex = 20;
            this.validateBuy.Text = "Valider";
            this.validateBuy.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(26, 106);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(99, 32);
            this.update.TabIndex = 21;
            this.update.Text = "Modifier";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // back_page
            // 
            this.back_page.Location = new System.Drawing.Point(26, 68);
            this.back_page.Name = "back_page";
            this.back_page.Size = new System.Drawing.Size(99, 32);
            this.back_page.TabIndex = 22;
            this.back_page.Text = "Retour";
            this.back_page.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Marque";
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock.Location = new System.Drawing.Point(263, 114);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(16, 17);
            this.stock.TabIndex = 24;
            this.stock.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Fournisseurs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(625, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Prix /u ";
            // 
            // listSupplier
            // 
            this.listSupplier.FormattingEnabled = true;
            this.listSupplier.Location = new System.Drawing.Point(258, 205);
            this.listSupplier.Name = "listSupplier";
            this.listSupplier.Size = new System.Drawing.Size(361, 69);
            this.listSupplier.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Informations";
            // 
            // price_u
            // 
            this.price_u.AutoSize = true;
            this.price_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_u.Location = new System.Drawing.Point(625, 205);
            this.price_u.Name = "price_u";
            this.price_u.Size = new System.Drawing.Size(24, 17);
            this.price_u.TabIndex = 29;
            this.price_u.Text = "3€";
            // 
            // addSup
            // 
            this.addSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSup.Location = new System.Drawing.Point(625, 225);
            this.addSup.Name = "addSup";
            this.addSup.Size = new System.Drawing.Size(92, 28);
            this.addSup.TabIndex = 30;
            this.addSup.Text = "Ajouter";
            this.addSup.UseVisualStyleBackColor = true;
            this.addSup.Click += new System.EventHandler(this.addSup_Click);
            // 
            // validateP
            // 
            this.validateP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateP.Location = new System.Drawing.Point(481, 368);
            this.validateP.Name = "validateP";
            this.validateP.Size = new System.Drawing.Size(76, 32);
            this.validateP.TabIndex = 35;
            this.validateP.Text = "Valider";
            this.validateP.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(369, 370);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 30);
            this.textBox1.TabIndex = 34;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(414, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 33);
            this.button3.TabIndex = 33;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(324, 368);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 33);
            this.button4.TabIndex = 32;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(180, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "Panier";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(26, 68);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(99, 38);
            this.back.TabIndex = 36;
            this.back.Text = "Retour";
            this.back.UseVisualStyleBackColor = true;
            // 
            // brand
            // 
            this.brand.AutoSize = true;
            this.brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand.Location = new System.Drawing.Point(181, 218);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(56, 17);
            this.brand.TabIndex = 37;
            this.brand.Text = "Marque";
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(625, 259);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(92, 28);
            this.delete.TabIndex = 38;
            this.delete.Text = "Supprimer";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Stocks_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.back);
            this.Controls.Add(this.validateP);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addSup);
            this.Controls.Add(this.price_u);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listSupplier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_page);
            this.Controls.Add(this.update);
            this.Controls.Add(this.validateBuy);
            this.Controls.Add(this.quantity_buy);
            this.Controls.Add(this.plus_buy);
            this.Controls.Add(this.minus_buy);
            this.Controls.Add(this.actual_stock);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label_buy);
            this.Controls.Add(this.name_product);
            this.Name = "Stocks_detail";
            this.Text = "Stocks_detail";
            this.Controls.SetChildIndex(this.Deconnexion, 0);
            this.Controls.SetChildIndex(this.name_product, 0);
            this.Controls.SetChildIndex(this.label_buy, 0);
            this.Controls.SetChildIndex(this.description, 0);
            this.Controls.SetChildIndex(this.actual_stock, 0);
            this.Controls.SetChildIndex(this.minus_buy, 0);
            this.Controls.SetChildIndex(this.plus_buy, 0);
            this.Controls.SetChildIndex(this.quantity_buy, 0);
            this.Controls.SetChildIndex(this.validateBuy, 0);
            this.Controls.SetChildIndex(this.update, 0);
            this.Controls.SetChildIndex(this.back_page, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.stock, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.listSupplier, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.price_u, 0);
            this.Controls.SetChildIndex(this.addSup, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.validateP, 0);
            this.Controls.SetChildIndex(this.back, 0);
            this.Controls.SetChildIndex(this.brand, 0);
            this.Controls.SetChildIndex(this.delete, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label name_product;
		private System.Windows.Forms.Label label_buy;
		private System.Windows.Forms.Label description;
		private System.Windows.Forms.Label actual_stock;
		private System.Windows.Forms.Button minus_buy;
		private System.Windows.Forms.Button plus_buy;
		private System.Windows.Forms.TextBox quantity_buy;
		private System.Windows.Forms.Button validateBuy;
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.Button back_page;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label stock;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox listSupplier;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label price_u;
		private System.Windows.Forms.Button addSup;
		private System.Windows.Forms.Button validateP;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.Button back;
        private System.Windows.Forms.Label brand;
        private System.Windows.Forms.Button delete;
    }
}