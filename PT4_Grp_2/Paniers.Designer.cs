namespace PT4_Grp_2
{
	partial class Paniers
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
			this.update = new System.Windows.Forms.Button();
			this.Delete = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.listArticles = new System.Windows.Forms.ListBox();
			this.name = new System.Windows.Forms.Label();
			this.plus_buy = new System.Windows.Forms.Button();
			this.minus_buy = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// update
			// 
			this.update.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.update.Location = new System.Drawing.Point(672, 402);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(108, 36);
			this.update.TabIndex = 34;
			this.update.Text = "Valider";
			this.update.UseVisualStyleBackColor = false;
			// 
			// Delete
			// 
			this.Delete.BackColor = System.Drawing.Color.DarkRed;
			this.Delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.Delete.Location = new System.Drawing.Point(169, 402);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(108, 36);
			this.Delete.TabIndex = 33;
			this.Delete.Text = "Vider";
			this.Delete.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(15, 149);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 36);
			this.button1.TabIndex = 32;
			this.button1.Text = "Supprimer";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// progressBar1
			// 
			this.progressBar1.BackColor = System.Drawing.Color.Honeydew;
			this.progressBar1.ForeColor = System.Drawing.Color.DarkSeaGreen;
			this.progressBar1.Location = new System.Drawing.Point(169, 380);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(611, 3);
			this.progressBar1.TabIndex = 31;
			// 
			// listArticles
			// 
			this.listArticles.FormattingEnabled = true;
			this.listArticles.Location = new System.Drawing.Point(169, 62);
			this.listArticles.Name = "listArticles";
			this.listArticles.Size = new System.Drawing.Size(611, 212);
			this.listArticles.TabIndex = 35;
			// 
			// name
			// 
			this.name.AutoSize = true;
			this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.name.Location = new System.Drawing.Point(169, 294);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(60, 17);
			this.name.TabIndex = 36;
			this.name.Text = "Total : ";
			// 
			// plus_buy
			// 
			this.plus_buy.Location = new System.Drawing.Point(15, 110);
			this.plus_buy.Name = "plus_buy";
			this.plus_buy.Size = new System.Drawing.Size(108, 33);
			this.plus_buy.TabIndex = 47;
			this.plus_buy.Text = "+";
			this.plus_buy.UseVisualStyleBackColor = true;
			// 
			// minus_buy
			// 
			this.minus_buy.Location = new System.Drawing.Point(15, 71);
			this.minus_buy.Name = "minus_buy";
			this.minus_buy.Size = new System.Drawing.Size(108, 33);
			this.minus_buy.TabIndex = 46;
			this.minus_buy.Text = "-";
			this.minus_buy.UseVisualStyleBackColor = true;
			// 
			// Paniers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.plus_buy);
			this.Controls.Add(this.minus_buy);
			this.Controls.Add(this.name);
			this.Controls.Add(this.listArticles);
			this.Controls.Add(this.update);
			this.Controls.Add(this.Delete);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.progressBar1);
			this.Name = "Paniers";
			this.Text = "Paniers";
			this.Controls.SetChildIndex(this.progressBar1, 0);
			this.Controls.SetChildIndex(this.button1, 0);
			this.Controls.SetChildIndex(this.Delete, 0);
			this.Controls.SetChildIndex(this.update, 0);
			this.Controls.SetChildIndex(this.listArticles, 0);
			this.Controls.SetChildIndex(this.name, 0);
			this.Controls.SetChildIndex(this.minus_buy, 0);
			this.Controls.SetChildIndex(this.plus_buy, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button update;
		private System.Windows.Forms.Button Delete;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label name;
		private System.Windows.Forms.Button plus_buy;
		private System.Windows.Forms.Button minus_buy;
		public System.Windows.Forms.ListBox listArticles;
	}
}