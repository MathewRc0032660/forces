﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double ans = sin(a);
                label1.Text = ans.ToString();
            }



            catch
            {
                MessageBox.Show("done it wrong mate");
            }
        }
        double sin(double a)
        {
            double rad = a / 180.0 * Math.PI;
            return Math.Sin(rad);



        }
        double invSin(double a)
        {
         return Math.Asin(a)
        }
    }
}
