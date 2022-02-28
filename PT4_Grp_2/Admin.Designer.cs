namespace PT4_Grp_2
{
    partial class   Admin
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
			this.Deconnexion = new System.Windows.Forms.Button();
			this.detail = new System.Windows.Forms.Button();
			this.listStaff = new System.Windows.Forms.ListBox();
			this.add = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Deconnexion
			// 
			this.Deconnexion.FlatAppearance.BorderSize = 0;
			this.Deconnexion.Location = new System.Drawing.Point(692, 12);
			this.Deconnexion.Name = "Deconnexion";
			this.Deconnexion.Size = new System.Drawing.Size(81, 24);
			this.Deconnexion.TabIndex = 3;
			this.Deconnexion.Text = "Deconnexion";
			this.Deconnexion.UseVisualStyleBackColor = true;
			this.Deconnexion.Click += new System.EventHandler(this.Deconnexion_Click);
			// 
			// detail
			// 
			this.detail.Location = new System.Drawing.Point(23, 131);
			this.detail.Name = "detail";
			this.detail.Size = new System.Drawing.Size(113, 36);
			this.detail.TabIndex = 13;
			this.detail.Text = "DETAIL";
			this.detail.UseVisualStyleBackColor = true;
			// 
			// listStaff
			// 
			this.listStaff.BackColor = System.Drawing.SystemColors.Info;
			this.listStaff.FormattingEnabled = true;
			this.listStaff.Location = new System.Drawing.Point(169, 58);
			this.listStaff.Name = "listStaff";
			this.listStaff.Size = new System.Drawing.Size(621, 381);
			this.listStaff.TabIndex = 12;
			// 
			// add
			// 
			this.add.Location = new System.Drawing.Point(23, 71);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(113, 36);
			this.add.TabIndex = 11;
			this.add.Text = "AJOUTER";
			this.add.UseVisualStyleBackColor = true;
			// 
			// Admin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.detail);
			this.Controls.Add(this.listStaff);
			this.Controls.Add(this.add);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "Admin";
			this.Text = "Admin";
			this.Controls.SetChildIndex(this.add, 0);
			this.Controls.SetChildIndex(this.listStaff, 0);
			this.Controls.SetChildIndex(this.detail, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.Button Deconnexion;
		private System.Windows.Forms.Button detail;
		private System.Windows.Forms.ListBox listStaff;
		private System.Windows.Forms.Button add;
	}
}