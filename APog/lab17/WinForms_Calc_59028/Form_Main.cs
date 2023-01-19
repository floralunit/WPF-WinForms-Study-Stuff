using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calc = ClassLib_Calc_59028.Calculator;

namespace WinForms_Calc_59028
{
    public partial class form_Main : Form
    {

        public form_Main()
        {
            InitializeComponent();

        }

        private void button_rightdraf_Click(object sender, EventArgs e)
        {
            short _first_value = Convert.ToInt16(textBox_num1.Text);
            short _second_value = Convert.ToInt16(textBox_num2.Text);
            string str_message = Calc.RShift(_first_value, _second_value);
            label_result.Text = str_message;
        }

        private void button_rightdraf_equal_Click(object sender, EventArgs e)
        {
            int _first_value = Convert.ToInt16(textBox_num1.Text);
            int _second_value = Convert.ToInt16(textBox_num2.Text);
            string str_message = Calc.RShift_equal(_first_value, _second_value);
            label_result.Text = str_message;
        }

        private void button_galka_equal_Click(object sender, EventArgs e)
        {
            int _first_value = Convert.ToInt16(textBox_num1.Text);
            int _second_value = Convert.ToInt16(textBox_num2.Text);
            string str_message = Calc.Xor_equal(_first_value, _second_value);
            label_result.Text = str_message;
        }

        private void button_galka_Click(object sender, EventArgs e)
        {
            short _first_value = Convert.ToInt16(textBox_num1.Text);
            short _second_value = Convert.ToInt16(textBox_num2.Text);
            string str_message = Calc.Xor(_first_value, _second_value);
            label_result.Text = str_message;
        }

        private void textBox_num1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox_num1.Text == "")
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == '-'))
                    return;
            }
            else
            {
                if ((e.KeyChar >= '1') && (e.KeyChar <= '9') && (textBox_num1.Text == "-"))
                    return;
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9') && (textBox_num1.Text != "0") && (textBox_num1.Text != "-"))
                    return;
            }
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void textBox_num2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox_num2.Text == "")
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == '-'))
                    return;
            }
            else
            {
                if ((e.KeyChar >= '1') && (e.KeyChar <= '9') && (textBox_num2.Text == "-"))
                    return;
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9') && (textBox_num2.Text != "0") && (textBox_num2.Text != "-"))
                    return;
            }
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }
    }
}
