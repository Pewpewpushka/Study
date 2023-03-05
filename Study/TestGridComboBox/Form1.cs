using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGridComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectItem = (string)comboBox1.SelectedItem;
            var row = dt.NewRow();
            row[0]=selectItem;
            dt.Rows.Add(row);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>() { "Name","Viscosity"};
            list.Add("Name2");
            comboBox1.DataSource= list;
        }
        public DataTable dt;
        private void button4_Click(object sender, EventArgs e)
        {
            //создали ссылку в куче на таблицу
            dt= new DataTable();
            //создали две колонки добавили в эту таблицу
            DataColumn column = new DataColumn("Столбик1");
            dt.Columns.Add(column);
            DataColumn colum1 = new DataColumn("Столбик2");
            dt.Columns.Add(colum1);
            // создали строчку на каждую колонку добавили значения двумя способами
            var row= dt.NewRow();
            row[0] = "ghghhghg";
            row["Столбик2"] = "fhfhfhfh";
            dt.Rows.Add(row);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;

        }
    }
}
