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
            this.add = new System.Windows.Forms.Button();
            this.listStaff = new System.Windows.Forms.ListBox();
            this.detail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 70);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 0;
            this.add.Text = "AJOUTER";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // listStaff
            // 
            this.listStaff.FormattingEnabled = true;
            this.listStaff.Location = new System.Drawing.Point(156, 70);
            this.listStaff.Name = "listStaff";
            this.listStaff.Size = new System.Drawing.Size(385, 355);
            this.listStaff.TabIndex = 1;
            // 
            // detail
            // 
            this.detail.Location = new System.Drawing.Point(12, 112);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(75, 23);
            this.detail.TabIndex = 2;
            this.detail.Text = "DETAIL";
            this.detail.UseVisualStyleBackColor = true;
            this.detail.Visible = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.detail);
            this.Controls.Add(this.listStaff);
            this.Controls.Add(this.add);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListBox listStaff;
        private System.Windows.Forms.Button detail;
    }
}