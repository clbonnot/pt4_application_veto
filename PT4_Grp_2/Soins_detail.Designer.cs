namespace PT4_Grp_2
{
	partial class Soins_detail
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
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.back_page = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.description = new System.Windows.Forms.Label();
			this.name_medic = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(178, 153);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 17);
			this.label5.TabIndex = 34;
			this.label5.Text = "Informations";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(189, 184);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 17);
			this.label1.TabIndex = 33;
			this.label1.Text = "Marque";
			// 
			// back_page
			// 
			this.back_page.Location = new System.Drawing.Point(22, 67);
			this.back_page.Name = "back_page";
			this.back_page.Size = new System.Drawing.Size(99, 32);
			this.back_page.TabIndex = 32;
			this.back_page.Text = "Retour";
			this.back_page.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(22, 105);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(99, 32);
			this.button1.TabIndex = 31;
			this.button1.Text = "Modifier";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// description
			// 
			this.description.AutoSize = true;
			this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.description.Location = new System.Drawing.Point(189, 256);
			this.description.Name = "description";
			this.description.Size = new System.Drawing.Size(79, 17);
			this.description.TabIndex = 30;
			this.description.Text = "Description";
			// 
			// name_medic
			// 
			this.name_medic.AutoSize = true;
			this.name_medic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.name_medic.Location = new System.Drawing.Point(176, 73);
			this.name_medic.Name = "name_medic";
			this.name_medic.Size = new System.Drawing.Size(109, 26);
			this.name_medic.TabIndex = 29;
			this.name_medic.Text = "Nom Soin";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(189, 218);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 17);
			this.label2.TabIndex = 35;
			this.label2.Text = "Contre-indications";
			// 
			// Soins_detail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.back_page);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.description);
			this.Controls.Add(this.name_medic);
			this.Name = "Soins_detail";
			this.Text = "Soins_detail";
			this.Controls.SetChildIndex(this.name_medic, 0);
			this.Controls.SetChildIndex(this.description, 0);
			this.Controls.SetChildIndex(this.button1, 0);
			this.Controls.SetChildIndex(this.back_page, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button back_page;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label description;
		private System.Windows.Forms.Label name_medic;
		private System.Windows.Forms.Label label2;
	}
}