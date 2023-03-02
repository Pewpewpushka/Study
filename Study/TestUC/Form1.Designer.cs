namespace TestUC
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControl21 = new TestUC.NewFolder1.UserControl2();
            this.userControl11 = new TestUC.NewFolder1.UserControl1();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.userControl21.Location = new System.Drawing.Point(845, 137);
            this.userControl21.MyPropertyText = "";
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(506, 300);
            this.userControl21.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl11.Location = new System.Drawing.Point(154, 115);
            this.userControl11.MyPropertyText = "кнопкашмпока";
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(637, 400);
            this.userControl11.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 649);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 22);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 819);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NewFolder1.UserControl1 userControl11;
        private NewFolder1.UserControl2 userControl21;
        private System.Windows.Forms.TextBox textBox1;
    }
}

