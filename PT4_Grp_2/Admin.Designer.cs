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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // detail
            // 
            this.detail.Visible = true;
            // 
            // listbox
            // 
            this.listbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listbox_MouseDoubleClick);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 67;
            this.label1.Text = "Admin";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Controls.SetChildIndex(this.listbox, 0);
            this.Controls.SetChildIndex(this.add, 0);
            this.Controls.SetChildIndex(this.detail, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.Button Deconnexion;
		private System.Windows.Forms.Label label1;
	}
}