using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestUC.NewFolder1;

namespace TestUC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //UserControl1.UserControlValueChanged += UserControl1_UserControlValueChanged;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.UserControlValueChanged += UserControl1_UserControlValueChanged;
        }
        private void UserControl1_UserControlValueChanged(object sender, string value)
        {
            // используйте значение, переданное из UserControl
            textBox1.Text = value;
        }
    }
}
