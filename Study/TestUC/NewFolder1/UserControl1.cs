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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public delegate void UserControlEventHandler(object sender, string value);
        public event UserControlEventHandler UserControlValueChanged;

        private void textBox1_TextChanged(object sender, EventArgs e)
       {
            UserControlValueChanged?.Invoke(this, textBox1.Text);

        }
    }
}
