using System;
using System.Collections.Generic;
using System.Text;

namespace Massives
//Вывод на экран двумерного массива (Герберт Шилдт)
{
    class _2Massive
    {

        static void print(int[][] alpha)
        {
            // Отображаем элементы массива
            for (int i = 0; i < alpha.Length; i++)
            {
                for (int j = 0; j < alpha[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", alpha[i][j], j == (alpha[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
        }

        static void a()
        {

            int[][] alpha = new int[4][];
            alpha[0] = new int[4] { 1, 2, 3, 4 };
            alpha[1] = new int[4] { 5, 6, 7, 8 };
            alpha[2] = new int[4] { 9, 10, 11, 12 };
            alpha[3] = new int[4] { 13, 14, 15, 16 };

            print(alpha);

            System.Console.WriteLine("Нажмите любую кнопку!");
            System.Console.ReadKey();
        }
    }
}