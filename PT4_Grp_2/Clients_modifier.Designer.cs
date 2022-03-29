namespace PT4_Grp_2
{
	partial class Clients_modifier
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
            this.mail = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
     

            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(219, 175);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(100, 20);
            this.mail.TabIndex = 38;
            this.mail.Text = "Adresse";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(29, 175);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(100, 20);
            this.phone.TabIndex = 37;
            this.phone.Text = "Téléphone";
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(219, 105);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(100, 20);
            this.firstname.TabIndex = 36;
            this.firstname.Text = "Prénom";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(29, 105);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 35;
            this.name.Text = "Nom";
            // 
            // Clients_modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 636);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.name);
            this.Name = "Clients_modifier";
            this.Text = "V";
            this.Controls.SetChildIndex(this.Delete, 0);
            this.Controls.SetChildIndex(this.update, 0);
            this.Controls.SetChildIndex(this.name, 0);
            this.Controls.SetChildIndex(this.firstname, 0);
            this.Controls.SetChildIndex(this.phone, 0);
            this.Controls.SetChildIndex(this.mail, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox mail;
		private System.Windows.Forms.TextBox phone;
		private System.Windows.Forms.TextBox firstname;
		private System.Windows.Forms.TextBox name;
	}
}