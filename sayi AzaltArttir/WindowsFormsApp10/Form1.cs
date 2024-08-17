using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi = double.Parse(textBox1.Text);
            if (radioButton1.Checked)
            {
                textBox1.Text = Convert.ToString(sayi + 10);


            }
            else if (radioButton2.Checked)
            {
                textBox1.Text = Convert.ToString(sayi - 10);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi = double.Parse(textBox1.Text);
            if (radioButton1.Checked)
            {
                textBox1.Text = Convert.ToString(sayi + 20);


            }
            else if (radioButton2.Checked)
            {
                textBox1.Text = Convert.ToString(sayi - 20);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi = double.Parse(textBox1.Text);
            if (radioButton1.Checked)
            {
                textBox1.Text = Convert.ToString(sayi + 30);


            }
            else if (radioButton2.Checked)
            {
                textBox1.Text = Convert.ToString(sayi - 30);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi = double.Parse(textBox1.Text);
            if (radioButton1.Checked)
            {
                textBox1.Text = Convert.ToString(sayi + 40);


            }
            else if (radioButton2.Checked)
            {
                textBox1.Text = Convert.ToString(sayi - 40);
            }
        }
    }
}
