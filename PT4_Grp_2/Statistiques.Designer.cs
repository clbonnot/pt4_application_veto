namespace PT4_Grp_2
{
    partial class Statistiques
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sales = new System.Windows.Forms.Button();
            this.clients = new System.Windows.Forms.Button();
            this.animals = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Deconnexion
            // 
            this.Deconnexion.FlatAppearance.BorderSize = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 31);
            this.label1.TabIndex = 67;
            this.label1.Text = "Statistiques";
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.MediumAquamarine;
            this.chart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(142, 134);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.chart.Size = new System.Drawing.Size(658, 316);
            this.chart.TabIndex = 68;
            // 
            // sales
            // 
            this.sales.Location = new System.Drawing.Point(206, 67);
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(92, 47);
            this.sales.TabIndex = 69;
            this.sales.Text = "Top ventes";
            this.sales.UseVisualStyleBackColor = true;
            this.sales.Click += new System.EventHandler(this.sales_Click);
            // 
            // clients
            // 
            this.clients.Location = new System.Drawing.Point(426, 67);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(92, 47);
            this.clients.TabIndex = 71;
            this.clients.Text = "Top Clients";
            this.clients.UseVisualStyleBackColor = true;
            // 
            // animals
            // 
            this.animals.Location = new System.Drawing.Point(657, 67);
            this.animals.Name = "animals";
            this.animals.Size = new System.Drawing.Size(92, 47);
            this.animals.TabIndex = 72;
            this.animals.Text = "Top Animaux";
            this.animals.UseVisualStyleBackColor = true;
            // 
            // Statistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.animals);
            this.Controls.Add(this.clients);
            this.Controls.Add(this.sales);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.label1);
            this.Name = "Statistiques";
            this.Text = "Statistiques";
            this.Controls.SetChildIndex(this.Deconnexion, 0);
            this.Controls.SetChildIndex(this.RoleName, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            this.Controls.SetChildIndex(this.sales, 0);
            this.Controls.SetChildIndex(this.clients, 0);
            this.Controls.SetChildIndex(this.animals, 0);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart;
		private System.Windows.Forms.Button sales;
		private System.Windows.Forms.Button clients;
		private System.Windows.Forms.Button animals;
	}
}