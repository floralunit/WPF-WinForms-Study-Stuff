using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Res_button_Click(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(textBox_Number.Text);
            int first = num / 10;
            int second = num % 10;
            if (num % 3 == 0)
            {
                krat3_label.Content = "Число делится на 3.";
            }
            else
            {
                krat3_label.Content = "Число не делится на 3.";
            }
            if (num % 2 == 0)
            {
                chet_label.Content = "Число является четным.";
            }
            else
            {
                chet_label.Content = "Число является нечетным.";
            }
            int sum = first + second;
            int mult = first * second;
            sum_label.Content = "Сумма цифр равна: " + sum;
            mult_label.Content = "Произведение цифр равно: " + mult;
        }
    }
}
