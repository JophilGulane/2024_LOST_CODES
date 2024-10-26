using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWithoutTutorial
{
    public partial class Form1 : Form
    {
        static string value = "";
        static string calculate = "";
        static double first_number;
        static double second_number;
        static bool sum = false;
        static bool sub = false;
        static bool mul = false;
        static bool div = false;
             
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            calculate += "7";
            label2.Text = calculate.ToString();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            calculate += "8";
            label2.Text = calculate.ToString();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            calculate += "9";
            label2.Text = calculate.ToString();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            calculate += "4";
            label2.Text = calculate.ToString();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            calculate += "5";
            label2.Text = calculate.ToString();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            calculate += "6";
            label2.Text = calculate.ToString();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            calculate += "1";
            label2.Text = calculate.ToString();
        }

        private void btn_2_Click(object sendr, EventArgs e)
        {
            calculate += "2";
            label2.Text = calculate.ToString();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            calculate += "3";
            label2.Text = calculate.ToString();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            calculate += "0";
            label2.Text = calculate.ToString();
        }

        private void btn_percent_Click(object sender, EventArgs e)
        {
            calculate += "%";
            label2.Text = calculate.ToString();
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            first_number = Convert.ToDouble(calculate);
            calculate += "/";
            label2.Text = calculate.ToString();
            calculate = "";
            sum = false;
            sub = false;
            mul = false;
            div = true;
            
        }

        private void btn_multiplication_Click(object sender, EventArgs e)
        {
            first_number = Convert.ToDouble(calculate);
            calculate += "*";
            label2.Text = calculate.ToString();
            calculate = "";
            sum = false;
            sub = false;
            mul = true;
            div = false;
            
        }

        private void btn_subtraction_Click(object sender, EventArgs e)
        {
            first_number = Convert.ToDouble(calculate);
            calculate += "-";
            label2.Text = calculate.ToString();
            calculate = "";
            sum = false;
            sub = true;
            mul = false;
            div = false;
        }

        private void btn_addition_Click(object sender, EventArgs e)
        {
            first_number = Convert.ToDouble(calculate);
            calculate += "+";
            label2.Text = calculate.ToString();
            calculate = "";
            sum = true;
            sub = false;
            mul = false;
            div = false;
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            second_number = Convert.ToDouble(calculate);
            if (sum)
            {
                calculate = (first_number + second_number).ToString();
                label2.Text = calculate.ToString();
            }
            else if (sub)
            {
                calculate = (first_number - second_number).ToString();
                label2.Text = calculate.ToString();
            }
            else if (mul)
            {
                calculate = (first_number * second_number).ToString();
                label2.Text = calculate.ToString();
            }
            else if (div)
            {
                calculate = (first_number / second_number).ToString();
                label2.Text = calculate.ToString();
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            calculate = calculate.Remove(calculate.Length - 1);

            label2.Text = calculate.ToString();
        }

        private void btn_AC_Click(object sender, EventArgs e)
        {
            calculate = "";
            label2.Text = "0";
        }
    }
}
