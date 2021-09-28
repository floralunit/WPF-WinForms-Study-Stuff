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
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Task4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new CurrentTimeViewModel();
        }
    }

    public class CurrentTimeViewModel : INotifyPropertyChanged
    {
        private string _currentTime;
        private string _vladivostokTime;

        public CurrentTimeViewModel()
        {
            UpdateTime();
            UpdateVladTime();
        }

        private async void UpdateTime()
        {
            CurrentTime = DateTime.Now.ToString("G");
            await Task.Delay(1000);
            UpdateTime();
        }
        private async void UpdateVladTime()
        {
            DateTime dateValue = DateTime.Now;
            VladivostokTime = dateValue.AddHours(7).ToString("G");
            await Task.Delay(1000);
            UpdateVladTime();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string CurrentTime
        {
            get { return _currentTime; }
            set { _currentTime = value; OnPropertyChanged(); }
        }
        public string VladivostokTime
        {
            get { return _vladivostokTime; }
            set { _vladivostokTime = value; OnPropertyChanged(); }
        }
    }
}
