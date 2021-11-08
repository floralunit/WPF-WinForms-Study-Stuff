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

namespace _2048game
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int COUNT = 4;
        private string[][] map = new string[COUNT][];
        public MainWindow()
        {
            Init();
            InitializeComponent();
            lst.ItemsSource = map;
        }
        private void Init()
        {
            for (int i = 0; i < COUNT; i++)
            {
                map[i] = new string[COUNT];
                for (int j = 0; j < COUNT; j++)
                {
                    map[i][j] = "";
                }
            }

            genRandom();
        }


        private void genRandom()
        {
            List<int[]> available = new List<int[]>();

            for (int i = 0; i < COUNT; i++)
            {
                for (int j = 0; j < COUNT; j++)
                {
                    if (map[i][j] == "")
                    {
                        available.Add(new int[] { i, j });
                    }
                }
            }

            Random random = new Random();
            int[] position = available[random.Next(available.Count())];
            map[position[0]][position[1]] = random.Next(1) == 0 ? "2" : "4";
        }

    }
}
