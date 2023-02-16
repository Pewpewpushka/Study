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
            this.dgvBlowingagents = new System.Windows.Forms.DataGridView();
            this.Вспениватели = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoliols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlowingagents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPoliols
            // 
            this.dgvPoliols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoliols.Location = new System.Drawing.Point(26, 26);
            this.dgvPoliols.Name = "dgvPoliols";
            this.dgvPoliols.RowHeadersWidth = 51;
            this.dgvPoliols.Size = new System.Drawing.Size(747, 58);
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
            // dgvBlowingagents
            // 
            this.dgvBlowingagents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlowingagents.Location = new System.Drawing.Point(26, 122);
            this.dgvBlowingagents.Name = "dgvBlowingagents";
            this.dgvBlowingagents.RowHeadersWidth = 51;
            this.dgvBlowingagents.RowTemplate.Height = 29;
            this.dgvBlowingagents.Size = new System.Drawing.Size(747, 72);
            this.dgvBlowingagents.TabIndex = 2;
            // 
            // Вспениватели
            // 
            this.Вспениватели.AutoSize = true;
            this.Вспениватели.Location = new System.Drawing.Point(26, 99);
            this.Вспениватели.Name = "Вспениватели";
            this.Вспениватели.Size = new System.Drawing.Size(169, 20);
            this.Вспениватели.TabIndex = 3;
            this.Вспениватели.Text = "Вспенивающие агенты";
            // 
            // UcBaseIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Вспениватели);
            this.Controls.Add(this.dgvBlowingagents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPoliols);
            this.Name = "UcBaseIngredients";
            this.Size = new System.Drawing.Size(828, 635);
            this.Load += new System.EventHandler(this.UcBaseIngredients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoliols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlowingagents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvPoliols;
        private Label label1;
        private DataGridView dgvBlowingagents;
        private Label Вспениватели;
    }
}
