namespace Chemestry.Calcul.Polyol_and_isocyanate.UserControls
{
    partial class UcBaseIngredients
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPoliols = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoliols)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPoliols
            // 
            this.dgvPoliols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoliols.Location = new System.Drawing.Point(26, 26);
            this.dgvPoliols.Name = "dgvPoliols";
            this.dgvPoliols.RowHeadersWidth = 51;
            this.dgvPoliols.Size = new System.Drawing.Size(300, 188);
            this.dgvPoliols.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Полиолы";
            // 
            // UcBaseIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPoliols);
            this.Name = "UcBaseIngredients";
            this.Size = new System.Drawing.Size(828, 635);
            this.Load += new System.EventHandler(this.UcBaseIngredients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoliols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvPoliols;
        private Label label1;
    }
}
