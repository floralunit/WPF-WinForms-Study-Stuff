using System;
using System.Collections.Generic;
using System.Text;

namespace Massives
// Отображение символьного массива
{
    class Massive_View
    {
        static void a()
        {
            int n = 5;
            string[] a = new string[n];
            string str;
            int i;
            a[0] = "Миссисипи";
            a[1] = "Нил";
            a[2] = "Амазонка";
            a[3] = "Енисей";
            a[4] = "Белая";

            str = "";

            for (i = 0; i < n; i++)
            {
                str += a[i] + "\n";
            }

            Console.WriteLine(str);
            Console.WriteLine("Нажмите любую кнопку!");
            Console.ReadKey();
        }
    }
}
