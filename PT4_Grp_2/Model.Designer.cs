﻿namespace PT4_Grp_2
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
            this.Deconnexion = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(21, 70);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(113, 36);
            this.add.TabIndex = 0;
            this.add.Text = "AJOUTER";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // listStaff
            // 
            this.listStaff.BackColor = System.Drawing.SystemColors.Info;
            this.listStaff.FormattingEnabled = true;
            this.listStaff.Location = new System.Drawing.Point(167, 57);
            this.listStaff.Name = "listStaff";
            this.listStaff.Size = new System.Drawing.Size(621, 381);
            this.listStaff.TabIndex = 1;
            // 
            // detail
            // 
            this.detail.Location = new System.Drawing.Point(21, 130);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(113, 36);
            this.detail.TabIndex = 2;
            this.detail.Text = "DETAIL";
            this.detail.UseVisualStyleBackColor = true;
            this.detail.Click += new System.EventHandler(this.detail_Click);
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGreen;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 5, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(16, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.DarkGreen;
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 5, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(16, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip3.GripMargin = new System.Windows.Forms.Padding(2, 5, 0, 2);
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(16, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip3.Location = new System.Drawing.Point(0, 48);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(151, 402);
            this.menuStrip3.TabIndex = 6;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 19);
            this.toolStripMenuItem1.Text = "                                          ";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Deconnexion);
            this.Controls.Add(this.detail);
            this.Controls.Add(this.listStaff);
            this.Controls.Add(this.add);
            this.Controls.Add(this.menuStrip3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListBox listStaff;
        private System.Windows.Forms.Button detail;
		private System.Windows.Forms.Button Deconnexion;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.MenuStrip menuStrip3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
	}
}