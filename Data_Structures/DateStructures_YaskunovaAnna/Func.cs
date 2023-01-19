using System;
using System.Collections.Generic;
using System.Text;

namespace Massives
//Массивы в качестве выходных параметров функций
{
    class Func
    {
        static void print(int[] alpha)
        {
            foreach (int i in alpha)
                Console.WriteLine(i + " ");
            Console.WriteLine();
        }

        static void FillArray(out int[] alpha)
        {
            // Создаем массив
            alpha = new int[5] { 1, 2, 3, 4, 5 };
        }

        static void a()
        {

            int[] alpha; // Не требуется инициализация

            // Заполняем массив
            FillArray(out alpha);

            // Отображаем элементы массива
            System.Console.WriteLine("Отображаем элементы массива:");

            print(alpha);

            System.Console.WriteLine("Нажмите любую кнопку!");
            System.Console.ReadKey();


        }
    }
}
