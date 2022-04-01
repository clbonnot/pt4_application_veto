namespace PT4_Grp_2
{
    partial class Soins
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
            this.listMedic = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Deconnexion
            // 
            this.Deconnexion.FlatAppearance.BorderSize = 0;
            this.Deconnexion.Location = new System.Drawing.Point(692, 12);
            this.Deconnexion.Name = "Deconnexion";
            this.Deconnexion.Size = new System.Drawing.Size(81, 24);
            this.Deconnexion.TabIndex = 10;
            this.Deconnexion.Text = "Deconnexion";
            this.Deconnexion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(340, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 31);
            this.label1.TabIndex = 67;
            this.label1.Text = "Soins";
            // 
            // listMedic
            // 
            this.listMedic.FormattingEnabled = true;
            this.listMedic.Location = new System.Drawing.Point(167, 70);
            this.listMedic.Name = "listMedic";
            this.listMedic.Size = new System.Drawing.Size(621, 277);
            this.listMedic.TabIndex = 68;
            // 
            // Soins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listMedic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Deconnexion);
            this.Name = "Soins";
            this.Text = "Soins";
            this.Controls.SetChildIndex(this.Deconnexion, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.listMedic, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button Deconnexion;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listMedic;
    }
}