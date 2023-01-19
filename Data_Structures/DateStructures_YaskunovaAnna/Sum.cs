using System;

namespace DateStructures_YaskunovaAnna
//Нахождение суммы массива
{
    class Sum
    {
        static void a(string[] args)
        {
                int n = 3;
                int[] a = new int[n];
                string str;
                int i;
                a[0] = 1;
                a[1] = -8;
                a[2] = 14;

                int sum = 0;

                for (i = 0; i < n; i++)
                {
                    sum += a[i];
                }
                str = "Сумма массива равна " + sum;
                Console.WriteLine(str);
                Console.WriteLine("Нажмите любую кнопку!");
                Console.ReadKey();
    }
    }
}
