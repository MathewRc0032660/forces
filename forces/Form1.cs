using System;
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
           
        }
        double sin(double a)
        {
            double rad = a / 180.0 * Math.PI;
            return Math.Sin(rad);



        }

        double cos(double a)
        {
            double rad = a / 180.0 * Math.PI;
            return Math.Cos(rad);



        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double F = double.Parse(textBox2.Text);
                double a = double.Parse(textBox1.Text);
                double ans = F * cos(a);
                double ans2 = F * sin(a);
                label2.Text = "Fx= " + ans + " N";
                label1.Text = "Fy= " + ans2 + " N";
            }



            catch
            {
                MessageBox.Show("done it wrong mate");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
