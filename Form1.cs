using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int Test;
        int x, y;
        char op;
        String "احبك";

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = button3.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = button2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = button1.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = button4.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = button7.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = button5.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = button8.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = button6.Text;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = button11.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = button9.Text;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            x = int.Parse(label1.Text);
            label1.Text = " ";
            op = '/';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = " ";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            switch(op)
            {
                case '+':
                    y = x + int.Parse(label1.Text);
                    label1.Text = y.ToString();
                    break;
                case '-':
                    y = x - int.Parse(label1.Text);
                    label1.Text = y.ToString();
                    break;
                case '*':
                    y = x * int.Parse(label1.Text);
                    label1.Text = y.ToString();

                    break;
                case '/':
                    if (int.Parse(label1.Text) == 0)
                    {
                        label1.Text = "Error";
                    }

                    else
                    {
                        y = x / int.Parse(label1.Text);
                        label1.Text = y.ToString();
                    }
                 
                    break;

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
            x = int.Parse(label1.Text);
            label1.Text = " ";
            op = '-';

        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = int.Parse(label1.Text);
            label1.Text = " ";
            op = '+';

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            x = int.Parse(label1.Text);
            label1.Text = " ";
            op = '*';
        }
    }
}
