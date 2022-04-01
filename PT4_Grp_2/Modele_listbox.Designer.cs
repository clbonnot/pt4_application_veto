namespace PT4_Grp_2
{
	partial class Modele_listbox
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
			this.detail = new System.Windows.Forms.Button();
			this.add = new System.Windows.Forms.Button();
			this.listMedic = new System.Windows.Forms.ListBox();
			this.progressBar2 = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// detail
			// 
			this.detail.Location = new System.Drawing.Point(22, 103);
			this.detail.Name = "detail";
			this.detail.Size = new System.Drawing.Size(107, 27);
			this.detail.TabIndex = 24;
			this.detail.Text = "DETAIL";
			this.detail.UseVisualStyleBackColor = true;
			this.detail.Visible = false;
			// 
			// add
			// 
			this.add.Location = new System.Drawing.Point(22, 70);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(107, 27);
			this.add.TabIndex = 23;
			this.add.Text = "AJOUTER";
			this.add.UseVisualStyleBackColor = true;
			// 
			// listbox
			// 
			this.listMedic.BackColor = System.Drawing.SystemColors.Info;
			this.listMedic.FormattingEnabled = true;
			this.listMedic.Location = new System.Drawing.Point(167, 70);
			this.listMedic.Name = "listbox";
			this.listMedic.Size = new System.Drawing.Size(621, 368);
			this.listMedic.TabIndex = 22;
			// 
			// progressBar2
			// 
			this.progressBar2.BackColor = System.Drawing.Color.Honeydew;
			this.progressBar2.ForeColor = System.Drawing.Color.DarkSeaGreen;
			this.progressBar2.Location = new System.Drawing.Point(12, 136);
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new System.Drawing.Size(129, 3);
			this.progressBar2.TabIndex = 25;
			// 
			// Modele_listbox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.progressBar2);
			this.Controls.Add(this.detail);
			this.Controls.Add(this.add);
			this.Controls.Add(this.listMedic);
			this.Name = "Modele_listbox";
			this.Text = "Modèle_listbox";
			this.Controls.SetChildIndex(this.listMedic, 0);
			this.Controls.SetChildIndex(this.add, 0);
			this.Controls.SetChildIndex(this.detail, 0);
			this.Controls.SetChildIndex(this.progressBar2, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button detail;
		private System.Windows.Forms.Button add;
		private System.Windows.Forms.ListBox listMedic;
		private System.Windows.Forms.ProgressBar progressBar2;
	}
}