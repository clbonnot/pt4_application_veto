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
			this.product_pic = new System.Windows.Forms.PictureBox();
			this.name_product = new System.Windows.Forms.Label();
			this.label_buy = new System.Windows.Forms.Label();
			this.description = new System.Windows.Forms.Label();
			this.actual_stock = new System.Windows.Forms.Label();
			this.minus_buy = new System.Windows.Forms.Button();
			this.plus_buy = new System.Windows.Forms.Button();
			this.quantity_buy = new System.Windows.Forms.TextBox();
			this.validate_buy = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.back_page = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.product_pic)).BeginInit();
			this.SuspendLayout();
			// 
			// product_pic
			// 
			this.product_pic.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.product_pic.Location = new System.Drawing.Point(601, 74);
			this.product_pic.Name = "product_pic";
			this.product_pic.Size = new System.Drawing.Size(172, 128);
			this.product_pic.TabIndex = 11;
			this.product_pic.TabStop = false;
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
			this.label_buy.Location = new System.Drawing.Point(181, 397);
			this.label_buy.Name = "label_buy";
			this.label_buy.Size = new System.Drawing.Size(115, 24);
			this.label_buy.TabIndex = 13;
			this.label_buy.Text = "Commander";
			// 
			// description
			// 
			this.description.AutoSize = true;
			this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.description.Location = new System.Drawing.Point(182, 236);
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
			this.minus_buy.Location = new System.Drawing.Point(325, 395);
			this.minus_buy.Name = "minus_buy";
			this.minus_buy.Size = new System.Drawing.Size(38, 33);
			this.minus_buy.TabIndex = 17;
			this.minus_buy.Text = "-";
			this.minus_buy.UseVisualStyleBackColor = true;
			// 
			// plus_buy
			// 
			this.plus_buy.Location = new System.Drawing.Point(415, 395);
			this.plus_buy.Name = "plus_buy";
			this.plus_buy.Size = new System.Drawing.Size(38, 33);
			this.plus_buy.TabIndex = 18;
			this.plus_buy.Text = "+";
			this.plus_buy.UseVisualStyleBackColor = true;
			// 
			// quantity_buy
			// 
			this.quantity_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quantity_buy.Location = new System.Drawing.Point(370, 397);
			this.quantity_buy.Name = "quantity_buy";
			this.quantity_buy.Size = new System.Drawing.Size(39, 30);
			this.quantity_buy.TabIndex = 19;
			this.quantity_buy.Text = "0";
			this.quantity_buy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// validate_buy
			// 
			this.validate_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.validate_buy.Location = new System.Drawing.Point(482, 395);
			this.validate_buy.Name = "validate_buy";
			this.validate_buy.Size = new System.Drawing.Size(76, 32);
			this.validate_buy.TabIndex = 20;
			this.validate_buy.Text = "Valider";
			this.validate_buy.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(657, 395);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(99, 32);
			this.button1.TabIndex = 21;
			this.button1.Text = "Modifier";
			this.button1.UseVisualStyleBackColor = true;
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
			// Stocks_detail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.back_page);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.validate_buy);
			this.Controls.Add(this.quantity_buy);
			this.Controls.Add(this.plus_buy);
			this.Controls.Add(this.minus_buy);
			this.Controls.Add(this.actual_stock);
			this.Controls.Add(this.description);
			this.Controls.Add(this.label_buy);
			this.Controls.Add(this.name_product);
			this.Controls.Add(this.product_pic);
			this.Name = "Stocks_detail";
			this.Text = "Stocks_detail";
			this.Controls.SetChildIndex(this.product_pic, 0);
			this.Controls.SetChildIndex(this.name_product, 0);
			this.Controls.SetChildIndex(this.label_buy, 0);
			this.Controls.SetChildIndex(this.description, 0);
			this.Controls.SetChildIndex(this.actual_stock, 0);
			this.Controls.SetChildIndex(this.minus_buy, 0);
			this.Controls.SetChildIndex(this.plus_buy, 0);
			this.Controls.SetChildIndex(this.quantity_buy, 0);
			this.Controls.SetChildIndex(this.validate_buy, 0);
			this.Controls.SetChildIndex(this.button1, 0);
			this.Controls.SetChildIndex(this.back_page, 0);
			((System.ComponentModel.ISupportInitialize)(this.product_pic)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox product_pic;
		private System.Windows.Forms.Label name_product;
		private System.Windows.Forms.Label label_buy;
		private System.Windows.Forms.Label description;
		private System.Windows.Forms.Label actual_stock;
		private System.Windows.Forms.Button minus_buy;
		private System.Windows.Forms.Button plus_buy;
		private System.Windows.Forms.TextBox quantity_buy;
		private System.Windows.Forms.Button validate_buy;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button back_page;
	}
}