using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа__3.Вариант_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            textBox3.Text = "Результаты работы программы ст. Кушнарёва" + Environment.NewLine;
            textBox3.Text += "При X=" + textBox1.Text + Environment.NewLine;
            textBox3.Text += "При B=" + textBox2.Text + Environment.NewLine;
            double f = 0;
            if (radioButton1.Checked == true)
                f = Math.Sinh(x);
            if (radioButton2.Checked == true)
                f = x * x;
            if (radioButton3.Checked == true)
                f = Math.Exp(x);

            double g;
            if (x > 0.5 && x * b < 10)
                g = Math.Exp(f - Math.Abs(b));
            else
                if (x * b > 0.1 && x * b < 0.5)
                g = Math.Sqrt(Math.Abs(f + b));
            else
                g = 2 * Math.Pow(f, 2);
            textBox3.Text += "G=" + g.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
    }
    
}
