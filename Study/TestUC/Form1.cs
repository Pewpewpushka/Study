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
        private BindingSource bindingSource;
        public Form1()
        {
            InitializeComponent();
            bindingSource= new BindingSource();
            bindingSource.DataSource = this.userControl11;
            Binding binding = new Binding("Text", bindingSource, "MyPropertyText");
            textBox1.DataBindings.Add(binding);
        }
        //UserControl1.UserControlValueChanged += UserControl1_UserControlValueChanged;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
      {
            //userControl11.Text = textBox1.Text;
            //this.userControl11.MyPropertyText= textBox1.Text;
        }
    }
}
