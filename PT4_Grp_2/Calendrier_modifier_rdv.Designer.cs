namespace PT4_Grp_2
{
	partial class Calendrier_modifier_rdv
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
			this.label6 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.listClient = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dateStart = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(267, 302);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 13);
			this.label6.TabIndex = 69;
			this.label6.Text = "Heure";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(270, 331);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(47, 20);
			this.textBox2.TabIndex = 68;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(40, 389);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 13);
			this.label4.TabIndex = 67;
			this.label4.Text = "Détail";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(43, 405);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(284, 20);
			this.textBox1.TabIndex = 66;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(69, 206);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 13);
			this.label3.TabIndex = 65;
			this.label3.Text = "Nom prénom";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 179);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 13);
			this.label2.TabIndex = 64;
			this.label2.Text = "Client sélectionné";
			// 
			// listClient
			// 
			this.listClient.FormattingEnabled = true;
			this.listClient.Location = new System.Drawing.Point(207, 179);
			this.listClient.Name = "listClient";
			this.listClient.Size = new System.Drawing.Size(120, 95);
			this.listClient.TabIndex = 63;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(40, 302);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 13);
			this.label5.TabIndex = 62;
			this.label5.Text = "Date";
			// 
			// dateStart
			// 
			this.dateStart.Location = new System.Drawing.Point(43, 328);
			this.dateStart.Name = "dateStart";
			this.dateStart.Size = new System.Drawing.Size(200, 20);
			this.dateStart.TabIndex = 61;
			// 
			// Calendrier_modifier_rdv
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(370, 637);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listClient);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dateStart);
			this.Name = "Calendrier_modifier_rdv";
			this.Text = "Calendrier_modifier_rdv";
			this.Controls.SetChildIndex(this.dateStart, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.listClient, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.textBox1, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.textBox2, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listClient;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dateStart;
	}
}