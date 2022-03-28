namespace PT4_Grp_2
{
	partial class Admin_modifier_pers
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
            this.nameTV = new System.Windows.Forms.TextBox();
            this.firstnameTV = new System.Windows.Forms.TextBox();
            this.phoneTV = new System.Windows.Forms.TextBox();
            this.addressTV = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.TextBox();
            this.plus_salary = new System.Windows.Forms.Button();
            this.minus_salary = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idTV = new System.Windows.Forms.TextBox();
            this.roles = new System.Windows.Forms.ComboBox();
            this.confirm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // nameTV
            // 
            this.nameTV.Location = new System.Drawing.Point(32, 78);
            this.nameTV.Name = "nameTV";
            this.nameTV.Size = new System.Drawing.Size(100, 20);
            this.nameTV.TabIndex = 31;
            this.nameTV.Text = "Nom";
            // 
            // firstnameTV
            // 
            this.firstnameTV.Location = new System.Drawing.Point(222, 78);
            this.firstnameTV.Name = "firstnameTV";
            this.firstnameTV.Size = new System.Drawing.Size(100, 20);
            this.firstnameTV.TabIndex = 32;
            this.firstnameTV.Text = "Prénom";
            // 
            // phoneTV
            // 
            this.phoneTV.Location = new System.Drawing.Point(32, 116);
            this.phoneTV.Name = "phoneTV";
            this.phoneTV.Size = new System.Drawing.Size(100, 20);
            this.phoneTV.TabIndex = 33;
            this.phoneTV.Text = "Téléphone";
            // 
            // addressTV
            // 
            this.addressTV.Location = new System.Drawing.Point(222, 116);
            this.addressTV.Name = "addressTV";
            this.addressTV.Size = new System.Drawing.Size(100, 20);
            this.addressTV.TabIndex = 34;
            this.addressTV.Text = "Adresse";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(32, 274);
            this.date.MaxDate = new System.DateTime(2022, 3, 28, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 35;
            this.date.Value = new System.DateTime(2022, 3, 25, 0, 0, 0, 0);
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 43;
            this.label3.Text = "Salaire";
            // 
            // salary
            // 
            this.salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary.Location = new System.Drawing.Point(80, 399);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(92, 30);
            this.salary.TabIndex = 46;
            this.salary.Text = "2000";
            this.salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // plus_salary
            // 
            this.plus_salary.Location = new System.Drawing.Point(178, 397);
            this.plus_salary.Name = "plus_salary";
            this.plus_salary.Size = new System.Drawing.Size(38, 33);
            this.plus_salary.TabIndex = 45;
            this.plus_salary.Text = "+";
            this.plus_salary.UseVisualStyleBackColor = true;
            this.plus_salary.Click += new System.EventHandler(this.plus_salary_Click);
            // 
            // minus_salary
            // 
            this.minus_salary.Location = new System.Drawing.Point(35, 397);
            this.minus_salary.Name = "minus_salary";
            this.minus_salary.Size = new System.Drawing.Size(38, 33);
            this.minus_salary.TabIndex = 44;
            this.minus_salary.Text = "-";
            this.minus_salary.UseVisualStyleBackColor = true;
            this.minus_salary.Click += new System.EventHandler(this.minus_salary_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "Date d\'embauche";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 49;
            this.label4.Text = "Rôle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 50;
            this.label5.Text = "Compte";
            // 
            // idTV
            // 
            this.idTV.Location = new System.Drawing.Point(32, 525);
            this.idTV.Name = "idTV";
            this.idTV.Size = new System.Drawing.Size(100, 20);
            this.idTV.TabIndex = 51;
            this.idTV.Text = "Identifiant";
            // 
            // roles
            // 
            this.roles.FormattingEnabled = true;
            this.roles.Location = new System.Drawing.Point(32, 204);
            this.roles.Name = "roles";
            this.roles.Size = new System.Drawing.Size(121, 21);
            this.roles.TabIndex = 54;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(240, 396);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(91, 33);
            this.confirm.TabIndex = 55;
            this.confirm.Text = "Confirmer";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 56;
            this.label6.Text = "Date de fin";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(32, 335);
            this.dateEnd.MaxDate = new System.DateTime(9922, 4, 8, 0, 0, 0, 0);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 20);
            this.dateEnd.TabIndex = 57;
            this.dateEnd.Value = new System.DateTime(2022, 3, 26, 0, 0, 0, 0);
            // 
            // Admin_modifier_pers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 642);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.roles);
            this.Controls.Add(this.idTV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.plus_salary);
            this.Controls.Add(this.minus_salary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.addressTV);
            this.Controls.Add(this.phoneTV);
            this.Controls.Add(this.firstnameTV);
            this.Controls.Add(this.nameTV);
            this.Name = "Admin_modifier_pers";
            this.Text = "Admin_modifier_pers";
            this.Controls.SetChildIndex(this.Delete, 0);
            this.Controls.SetChildIndex(this.update, 0);
            this.Controls.SetChildIndex(this.nameTV, 0);
            this.Controls.SetChildIndex(this.firstnameTV, 0);
            this.Controls.SetChildIndex(this.phoneTV, 0);
            this.Controls.SetChildIndex(this.addressTV, 0);
            this.Controls.SetChildIndex(this.date, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.minus_salary, 0);
            this.Controls.SetChildIndex(this.plus_salary, 0);
            this.Controls.SetChildIndex(this.salary, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.idTV, 0);
            this.Controls.SetChildIndex(this.roles, 0);
            this.Controls.SetChildIndex(this.confirm, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.dateEnd, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox nameTV;
		private System.Windows.Forms.TextBox firstnameTV;
		private System.Windows.Forms.TextBox phoneTV;
		private System.Windows.Forms.TextBox addressTV;
		private System.Windows.Forms.DateTimePicker date;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox salary;
		private System.Windows.Forms.Button plus_salary;
		private System.Windows.Forms.Button minus_salary;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox idTV;
        private System.Windows.Forms.ComboBox roles;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateEnd;
    }
}