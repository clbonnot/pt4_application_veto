namespace PT4_Grp_2
{
	partial class Calendrier_modifier_conge
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
			this.dateStart = new System.Windows.Forms.DateTimePicker();
			this.dateEnd = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.dateOrigin = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.nbJours = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// dateStart
			// 
			this.dateStart.Location = new System.Drawing.Point(81, 232);
			this.dateStart.Name = "dateStart";
			this.dateStart.Size = new System.Drawing.Size(200, 20);
			this.dateStart.TabIndex = 31;
			// 
			// dateEnd
			// 
			this.dateEnd.Location = new System.Drawing.Point(82, 337);
			this.dateEnd.Name = "dateEnd";
			this.dateEnd.Size = new System.Drawing.Size(200, 20);
			this.dateEnd.TabIndex = 32;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(142, 17);
			this.label2.TabIndex = 33;
			this.label2.Text = "Congé sélectionné";
			// 
			// dateOrigin
			// 
			this.dateOrigin.AutoSize = true;
			this.dateOrigin.Location = new System.Drawing.Point(25, 108);
			this.dateOrigin.Name = "dateOrigin";
			this.dateOrigin.Size = new System.Drawing.Size(110, 13);
			this.dateOrigin.TabIndex = 34;
			this.dateOrigin.Text = "date_début / date_fin";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(79, 309);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 13);
			this.label4.TabIndex = 35;
			this.label4.Text = "Date de fin";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(78, 202);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 13);
			this.label5.TabIndex = 36;
			this.label5.Text = "Date de début";
			// 
			// nbJours
			// 
			this.nbJours.AutoSize = true;
			this.nbJours.Location = new System.Drawing.Point(25, 134);
			this.nbJours.Name = "nbJours";
			this.nbJours.Size = new System.Drawing.Size(76, 13);
			this.nbJours.TabIndex = 37;
			this.nbJours.Text = "nbJours totaux";
			// 
			// Calendrier_modifier_conge
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(362, 639);
			this.Controls.Add(this.nbJours);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dateOrigin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dateEnd);
			this.Controls.Add(this.dateStart);
			this.Name = "Calendrier_modifier_conge";
			this.Text = "Calendrier_add_conge";
			this.Controls.SetChildIndex(this.dateStart, 0);
			this.Controls.SetChildIndex(this.dateEnd, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.dateOrigin, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.nbJours, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateStart;
		private System.Windows.Forms.DateTimePicker dateEnd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label dateOrigin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label nbJours;
	}
}