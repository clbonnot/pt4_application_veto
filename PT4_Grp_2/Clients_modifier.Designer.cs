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
			this.streetTV = new System.Windows.Forms.TextBox();
			this.phoneTV = new System.Windows.Forms.TextBox();
			this.firstnameTV = new System.Windows.Forms.TextBox();
			this.nameTV = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// streetTV
			// 
			this.streetTV.Location = new System.Drawing.Point(219, 175);
			this.streetTV.Name = "streetTV";
			this.streetTV.Size = new System.Drawing.Size(100, 20);
			this.streetTV.TabIndex = 38;
			this.streetTV.Text = "Adresse";
			// 
			// phoneTV
			// 
			this.phoneTV.Location = new System.Drawing.Point(29, 175);
			this.phoneTV.Name = "phoneTV";
			this.phoneTV.Size = new System.Drawing.Size(100, 20);
			this.phoneTV.TabIndex = 37;
			this.phoneTV.Text = "Téléphone";
			// 
			// firstnameTV
			// 
			this.firstnameTV.Location = new System.Drawing.Point(219, 105);
			this.firstnameTV.Name = "firstnameTV";
			this.firstnameTV.Size = new System.Drawing.Size(100, 20);
			this.firstnameTV.TabIndex = 36;
			this.firstnameTV.Text = "Prénom";
			// 
			// nameTV
			// 
			this.nameTV.Location = new System.Drawing.Point(29, 105);
			this.nameTV.Name = "nameTV";
			this.nameTV.Size = new System.Drawing.Size(100, 20);
			this.nameTV.TabIndex = 35;
			this.nameTV.Text = "Nom";
			// 
			// Clients_modifier
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(362, 636);
			this.Controls.Add(this.streetTV);
			this.Controls.Add(this.phoneTV);
			this.Controls.Add(this.firstnameTV);
			this.Controls.Add(this.nameTV);
			this.Name = "Clients_modifier";
			this.Text = "V";
			this.Controls.SetChildIndex(this.nameTV, 0);
			this.Controls.SetChildIndex(this.firstnameTV, 0);
			this.Controls.SetChildIndex(this.phoneTV, 0);
			this.Controls.SetChildIndex(this.streetTV, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox streetTV;
		private System.Windows.Forms.TextBox phoneTV;
		private System.Windows.Forms.TextBox firstnameTV;
		private System.Windows.Forms.TextBox nameTV;
	}
}