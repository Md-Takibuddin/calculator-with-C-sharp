using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

        private int firstNum = 0;
        private int secendNum = 0;
        private bool flag = false;
        private char opt = ' ';
        private int result = 0;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToInt32(textbox.Text);
            label.Text = firstNum + " / ";
            flag = true;
            opt = '/';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(flag==false)
            textbox.Text += "3";
            else
            textbox.Text = "3";
            flag = false;
        }
        private void b0_Click(object sender, EventArgs e)
        {
            if(flag == false)
                textbox.Text += "0";
            else
                textbox.Text = "0";
            flag = false;
        }
        private void b1_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textbox.Text += "1";
            else
                textbox.Text = "1";
            flag = false;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textbox.Text += "2";
            else
                textbox.Text = "2";
            flag = false;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textbox.Text += "4";
            else
                textbox.Text = "4";
            flag = false;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textbox.Text += "5";
            else
                textbox.Text = "5";
            flag = false;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textbox.Text += "6";
            else
                textbox.Text = "6";
            flag = false;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textbox.Text += "7";
            else
                textbox.Text = "7";
            flag = false;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textbox.Text += "8";
            else
                textbox.Text = "8";
            flag = false;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (flag == false)
                textbox.Text += "9";
            else
                textbox.Text = "9";
            flag = false;
        }

        private void op1_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToInt32(textbox.Text);
            label.Text = firstNum + " + ";
            flag = true;
            opt = '+';

        }

        private void op2_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToInt32(textbox.Text);
            label.Text = firstNum + " - ";
            flag = true;
            opt = '-';
        }

        private void op3_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToInt32(textbox.Text);
            label.Text = firstNum + " x ";
            flag = true;
            opt = 'x';
        }

        private void op_Click(object sender, EventArgs e)
        {
            secendNum = Convert.ToInt32(textbox.Text);
            if(opt == '+')
            {
                result = firstNum + secendNum;
                textbox.Text = result+ "" ;
                label.Text = firstNum + " + " + secendNum;
                flag = true;
            }
            else if (opt == '-')
            {
                result = firstNum - secendNum;
                textbox.Text = result + "";
                label.Text = firstNum + " - " + secendNum;
                flag = true;
            }
            else if (opt == 'x')
            {
                result = firstNum * secendNum;
                textbox.Text = result + "";
                label.Text = firstNum + " x " + secendNum;
                flag = true;
            }
            else if (opt == '/')
            {
                result = firstNum / secendNum;
                textbox.Text = result + "";
                label.Text = firstNum + " / " + secendNum;
                flag = true;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textbox.Clear();
            label.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
