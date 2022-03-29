
namespace PT4_Grp_2
{
    partial class Clients_Race_add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients_Race_add));
            this.name = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.species = new System.Windows.Forms.ComboBox();
            this.addType = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.validate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            // 
            // description
            // 
            resources.ApplyResources(this.description, "description");
            this.description.Name = "description";
            // 
            // species
            // 
            this.species.FormattingEnabled = true;
            resources.ApplyResources(this.species, "species");
            this.species.Name = "species";
            // 
            // addType
            // 
            resources.ApplyResources(this.addType, "addType");
            this.addType.Name = "addType";
            this.addType.UseVisualStyleBackColor = true;
            this.addType.Click += new System.EventHandler(this.addType_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // validate
            // 
            resources.ApplyResources(this.validate, "validate");
            this.validate.Name = "validate";
            this.validate.UseVisualStyleBackColor = true;
            this.validate.Click += new System.EventHandler(this.validate_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Clients_Race_add
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addType);
            this.Controls.Add(this.species);
            this.Controls.Add(this.description);
            this.Controls.Add(this.name);
            this.Name = "Clients_Race_add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.ComboBox species;
        private System.Windows.Forms.Button addType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}