namespace PT4_Grp_2
{
    partial class Clients
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
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listbox
            // 
            this.listbox.DoubleClick += new System.EventHandler(this.listbox_DoubleClick);
            // 
            // Deconnexion
            // 
            this.Deconnexion.FlatAppearance.BorderSize = 0;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.DarkRed;
            this.Delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Delete.Location = new System.Drawing.Point(16, 322);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(108, 36);
            this.Delete.TabIndex = 30;
            this.Delete.Text = "Supprimer";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Delete);
            this.Name = "Clients";
            this.Text = "Clients";
            this.Controls.SetChildIndex(this.RoleName, 0);
            this.Controls.SetChildIndex(this.Deconnexion, 0);
            this.Controls.SetChildIndex(this.listbox, 0);
            this.Controls.SetChildIndex(this.add, 0);
            this.Controls.SetChildIndex(this.detail, 0);
            this.Controls.SetChildIndex(this.Delete, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Delete;
    }
}