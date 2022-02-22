using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace MD5_Algorithm
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void string1_TextChanged(object sender, TextChangedEventArgs e)
        {
            hashCompare();
        }

        private void string2_TextChanged(object sender, TextChangedEventArgs e)
        {
            hashCompare();
        }

        public void hashCompare()
        {
            if (string1 != null && string2 != null && label3 != null && string1.Text != "" && string2.Text != "")
            {
                MD5 md5 = MD5.Create();
                var hash1 = Convert.ToBase64String(md5.ComputeHash(Encoding.UTF8.GetBytes(string1.Text)));
                label1.Content = "MD5 хэш строки: " + hash1;
                var hash2 = Convert.ToBase64String(md5.ComputeHash(Encoding.UTF8.GetBytes(string2.Text)));
                label2.Content = "MD5 хэш строки: " + hash2;
                label3.Content = hash1 == hash2 ? "Хэши совпадают" : "Хэши не совпадают";
            }
            else
            {
                if (label3 != null) label3.Content = "Заполните обе строки";
            }
        }
    }
}
