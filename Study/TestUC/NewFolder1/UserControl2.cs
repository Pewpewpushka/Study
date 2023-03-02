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

        public string MyPropertyText { get => textBox1.Text; set => textBox1.Text = value; }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
