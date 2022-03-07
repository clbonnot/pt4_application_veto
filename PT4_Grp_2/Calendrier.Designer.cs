namespace PT4_Grp_2
{
    partial class Calendrier
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
            this.ChoixCal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ChoixCal
            // 
            this.ChoixCal.FormattingEnabled = true;
            this.ChoixCal.Items.AddRange(new object[] {
            "Horaires et Congés",
            "Rendez-vous"});
            this.ChoixCal.Location = new System.Drawing.Point(155, 52);
            this.ChoixCal.Name = "ChoixCal";
            this.ChoixCal.Size = new System.Drawing.Size(121, 21);
            this.ChoixCal.TabIndex = 11;
            this.ChoixCal.SelectedIndexChanged += new System.EventHandler(this.ChoixCal_SelectedIndexChanged);
            // 
            // Calendrier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChoixCal);
            this.Name = "Calendrier";
            this.Text = "Calendrier";
            this.Controls.SetChildIndex(this.ChoixCal, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ChoixCal;
    }
}