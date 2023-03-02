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
        //private BindingSource bindingSource;
        public Form1()
        {
            InitializeComponent();
            //bindingSource= new BindingSource();
            //bindingSource.DataSource = this.userControl11;
            //Binding binding = new Binding("Text", bindingSource, "MyPropertyText");
            //textBox1.DataBindings.Add(binding);
        }
        
        public string TextFromForm { get => textBox1.Text; set => textBox1.Text = value; }
        private void Form1_Load(object sender, EventArgs e)
        {
            TextFromForm = this.userControl11.MyPropertyText;
            this.userControl21.MyPropertyText = TextFromForm;
        }

       

       

    }
}
