using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestUC.NewFolder1
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        public string MyProperty { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            var mainForm = (Form1)this.ParentForm;
            textBox1.Text = mainForm.MyProperty;
        }
    }
}
