﻿using Chemestry.Calcul.Polyol_and_isocyanate.Model.Ingredients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chemestry.Calcul.Polyol_and_isocyanate.UserControls
{
    public partial class UcElastic : UserControl
    {
        public UcElastic()
        {
            InitializeComponent();
        }
        public List<Polyol> Polyols { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text= Polyols
            string result = string.Empty;
            for (int i = 0; i < Polyols.Count-1; i++)
            {
                result += Polyols[i].Name + Environment.NewLine;

            }
            textBox1.Text = result;
        }
    }
}
