namespace PT4_Grp_2
{
	partial class Stocks_modifier
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
            this.price = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.brand = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.name_medic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(201, 427);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(59, 20);
            this.price.TabIndex = 78;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(77, 427);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(59, 20);
            this.quantity.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 76;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 75;
            this.label2.Text = "Quantite";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(77, 359);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(209, 20);
            this.description.TabIndex = 74;
            // 
            // brand
            // 
            this.brand.Location = new System.Drawing.Point(77, 286);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(209, 20);
            this.brand.TabIndex = 73;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(66, 182);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 71;
            this.label5.Text = "Informations";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 70;
            this.label4.Text = "Marque";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(74, 328);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(79, 17);
            this.c.TabIndex = 69;
            this.c.Text = "Description";
            // 
            // name_medic
            // 
            this.name_medic.AutoSize = true;
            this.name_medic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_medic.Location = new System.Drawing.Point(61, 152);
            this.name_medic.Name = "name_medic";
            this.name_medic.Size = new System.Drawing.Size(59, 26);
            this.name_medic.TabIndex = 68;
            this.name_medic.Text = "Nom";
            // 
            // Stocks_modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 646);
            this.Controls.Add(this.price);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.description);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.c);
            this.Controls.Add(this.name_medic);
            this.Name = "Stocks_modifier";
            this.Text = "Stocks_modifier";
            this.Controls.SetChildIndex(this.Delete, 0);
            this.Controls.SetChildIndex(this.update, 0);
            this.Controls.SetChildIndex(this.name_medic, 0);
            this.Controls.SetChildIndex(this.c, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.name, 0);
            this.Controls.SetChildIndex(this.brand, 0);
            this.Controls.SetChildIndex(this.description, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.quantity, 0);
            this.Controls.SetChildIndex(this.price, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox brand;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label name_medic;
    }
}