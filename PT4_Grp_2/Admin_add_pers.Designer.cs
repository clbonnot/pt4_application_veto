namespace PT4_Grp_2
{
	partial class Admin_add_pers
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
            this.role = new System.Windows.Forms.ComboBox();
            this.Identify = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.endDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // role
            // 
            this.role.FormattingEnabled = true;
            this.role.Location = new System.Drawing.Point(276, 251);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(121, 21);
            this.role.TabIndex = 30;
            this.role.Text = "Rôle";
            // 
            // Identify
            // 
            this.Identify.Location = new System.Drawing.Point(276, 290);
            this.Identify.Name = "Identify";
            this.Identify.Size = new System.Drawing.Size(100, 20);
            this.Identify.TabIndex = 31;
            this.Identify.Text = "Identifiant";
            this.Identify.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(525, 290);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 32;
            this.password.Text = "MotDePasse";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(276, 331);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(100, 20);
            this.salary.TabIndex = 33;
            this.salary.Text = "Salaire";
            this.salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(525, 331);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(100, 20);
            this.endDate.TabIndex = 34;
            this.endDate.Text = "Date Fin Contrat";
            this.endDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Admin_add_pers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Identify);
            this.Controls.Add(this.role);
            this.Name = "Admin_add_pers";
            this.Text = "Admin_add_pers";
            this.Controls.SetChildIndex(this.FirstName, 0);
            this.Controls.SetChildIndex(this.LastName, 0);
            this.Controls.SetChildIndex(this.Phone, 0);
            this.Controls.SetChildIndex(this.Address, 0);
            this.Controls.SetChildIndex(this.valider, 0);
            this.Controls.SetChildIndex(this.role, 0);
            this.Controls.SetChildIndex(this.Identify, 0);
            this.Controls.SetChildIndex(this.password, 0);
            this.Controls.SetChildIndex(this.salary, 0);
            this.Controls.SetChildIndex(this.endDate, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox role;
        private System.Windows.Forms.TextBox Identify;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.TextBox endDate;
    }
}