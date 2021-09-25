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
using System.Threading;

namespace _8Ball
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

        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            // Ставим курсор ожидания.
            this.Cursor = Cursors.Wait;
            // Делаем задержку, для создания эффекта того, что программа задумалась.
            Thread.Sleep(TimeSpan.FromSeconds(1));
            // Берем случайный ответ.
            txtAnswer.Text = AnswerGenerator.GetRandomAnswer();
            // Восстанавливаем прежнее состояние курсора.
            this.Cursor = null;
        }
        private void txtQuestion_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
        public class AnswerGenerator
        {
            public static string GetRandomAnswer()
            {
                var rand = new Random();
                string text_answer;
                string[] answers = new string[4]
                {
                    "Абсолютно точно", "Вероятно", "Очень Сомнительно", "Ни в коем случае"
                };
                text_answer = answers[rand.Next(0, 4)];
                return text_answer;
            }
        }
            
    }
}
