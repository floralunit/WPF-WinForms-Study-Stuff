using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_FormatOutputBox;

namespace WinFormsApp_FormatOutputBox_59028
{
    public partial class form_Main : Form
    {
        private FormatOutputBox_GUI _outputBox = new FormatOutputBox_GUI();
        private int? _A = null; // переменные для ввода данных 
        private int? _B = null; // "int?" в отличие от "int" позволяет задавать null
        private int _index = 0; // индекс операции  
        public form_Main()
        {
            InitializeComponent();

        }

        private void listBox_Input_SelectedIndexChanged(object sender, EventArgs e)
        {
            _index = listBox_Input.SelectedIndex; // запоминаем выбранный индекс операции
            _outputBox.Invoke_Data(_index, ref pictureBox_Preview, ref richTextBox_Output); // инициализируем 
        }

        private void button_Evaluate_Click(object sender, EventArgs e)
        {
            int _A = Convert.ToInt16(textBox_A.Text);
            int _B = Convert.ToInt16(textBox_B.Text);
            //if (_A != null && _B != null)
            // {
            _outputBox.Execute_Data(_A, _B);// выполняем действие в зависимости от выбранной операции
            //}
        }

        private void textBox_A_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (Int32.TryParse(textBox_A.Text, out value))
            {
                _A = value; // обновляем переменную класса, если парсинг выполнен 
            }
            else
            {
                _A = null; // преобразование не было выполнено 
            }
        }

        private void textBox_B_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (Int32.TryParse(textBox_B.Text, out value))
            {
                _A = value; // обновляем переменную класса, если парсинг выполнен 
            }
            else
            {
                _A = null; // преобразование не было выполнено 
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            _outputBox.Clear_Data();
        }

        private void textBox_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox_A.Text == "")
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == '-'))
                    return;
            }
            else
            {
                if ((e.KeyChar >= '1') && (e.KeyChar <= '9') && (textBox_A.Text == "-"))
                    return;
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9') && (textBox_A.Text != "0") && (textBox_A.Text != "-"))
                    return;
            }
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void textBox_B_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox_B.Text == "")
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == '-'))
                    return;
            }
            else
            {
                if ((e.KeyChar >= '1') && (e.KeyChar <= '9') && (textBox_B.Text == "-"))
                    return;
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9') && (textBox_B.Text != "0") && (textBox_B.Text != "-"))
                    return;
            }
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }
    }
}
