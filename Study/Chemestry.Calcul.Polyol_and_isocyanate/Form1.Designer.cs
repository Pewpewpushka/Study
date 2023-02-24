namespace Chemestry.Calcul.Polyol_and_isocyanate
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.panel1 = new System.Windows.Forms.Panel();
            this.uсRigin1 = new Chemestry.Calcul.Polyol_and_isocyanate.UserControls.UсRigin();
            this.ucElastic1 = new Chemestry.Calcul.Polyol_and_isocyanate.UserControls.UcElastic();
            this.ucBaseIngredients1 = new Chemestry.Calcul.Polyol_and_isocyanate.UserControls.UcBaseIngredients();
            this.btElastic = new System.Windows.Forms.Button();
            this.btRegin = new System.Windows.Forms.Button();
            this.btBaseIngrelients = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uсRigin1);
            this.panel1.Controls.Add(this.ucElastic1);
            this.panel1.Controls.Add(this.ucBaseIngredients1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(199, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 862);
            this.panel1.TabIndex = 0;
            // 
            // uсRigin1
            // 
            this.uсRigin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uсRigin1.Location = new System.Drawing.Point(0, 0);
            this.uсRigin1.Name = "uсRigin1";
            this.uсRigin1.Size = new System.Drawing.Size(1231, 862);
            this.uсRigin1.TabIndex = 2;
            // 
            // ucElastic1
            // 
            this.ucElastic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucElastic1.Location = new System.Drawing.Point(0, 0);
            this.ucElastic1.Name = "ucElastic1";
            this.ucElastic1.Size = new System.Drawing.Size(1231, 862);
            this.ucElastic1.TabIndex = 1;
            // 
            // ucBaseIngredients1
            // 
            this.ucBaseIngredients1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBaseIngredients1.Location = new System.Drawing.Point(0, 0);
            this.ucBaseIngredients1.Name = "ucBaseIngredients1";
            this.ucBaseIngredients1.Size = new System.Drawing.Size(1231, 862);
            this.ucBaseIngredients1.TabIndex = 0;
            // 
            // btElastic
            // 
            this.btElastic.Location = new System.Drawing.Point(35, 159);
            this.btElastic.Name = "btElastic";
            this.btElastic.Size = new System.Drawing.Size(149, 38);
            this.btElastic.TabIndex = 1;
            this.btElastic.Text = "Эластичное ППУ";
            this.btElastic.UseVisualStyleBackColor = true;
            this.btElastic.Click += new System.EventHandler(this.btElastic_Click);
            // 
            // btRegin
            // 
            this.btRegin.Location = new System.Drawing.Point(35, 243);
            this.btRegin.Name = "btRegin";
            this.btRegin.Size = new System.Drawing.Size(149, 39);
            this.btRegin.TabIndex = 2;
            this.btRegin.Text = "Жесткие ППУ";
            this.btRegin.UseVisualStyleBackColor = true;
            this.btRegin.Click += new System.EventHandler(this.btRegin_Click);
            // 
            // btBaseIngrelients
            // 
            this.btBaseIngrelients.Location = new System.Drawing.Point(25, 311);
            this.btBaseIngrelients.Name = "btBaseIngrelients";
            this.btBaseIngrelients.Size = new System.Drawing.Size(168, 46);
            this.btBaseIngrelients.TabIndex = 3;
            this.btBaseIngrelients.Text = "База ингредиентов";
            this.btBaseIngrelients.UseVisualStyleBackColor = true;
            this.btBaseIngrelients.Click += new System.EventHandler(this.btBaseIngrelients_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 862);
            this.Controls.Add(this.btBaseIngrelients);
            this.Controls.Add(this.btRegin);
            this.Controls.Add(this.btElastic);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private Panel panel1;
        private Button btElastic;
        private Button btRegin;
        private Button btBaseIngrelients;
        private UserControls.UcBaseIngredients ucBaseIngredients1;
        private UserControls.UсRigin uсRigin1;
        private UserControls.UcElastic ucElastic1;
    }
}