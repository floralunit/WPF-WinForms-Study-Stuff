using System;
using System.Collections.Generic;
using System.Text;

namespace Massives
//Определение факторов геометрического снижения точности ГЛОНАСС
{
    class Glonass
    {
        static void print(double[,] alpha)
        {
            int ArraySize = 4;

            for (int i = 0; i < ArraySize; i++)
            {
                for (int j = 0; j < ArraySize; j++)
                {
                    Console.Write("{0}{1}", alpha[i, j], j == (ArraySize - 1) ? "" : " ");
                }
                Console.WriteLine();
            }
        }

        static void transpositiong(double[,] alpha)
        {
            int ArraySize = 4;
            double x;
            for (int i = 0; i < ArraySize - 1; i++)
                for (int j = i + 1; j < ArraySize; j++)
                {
                    x = alpha[i, j];
                    alpha[i, j] = alpha[j, i];
                    alpha[j, i] = x;
                }
        }

        static void multiplying(double[,] a, double[,] b, double[,] M)
        {
            int ArraySize = 4;
            int irow, icol, k;
            double sum;

            for (irow = 0; irow < ArraySize; irow++)
                for (icol = 0; icol < ArraySize; icol++)
                {
                    sum = 0;
                    for (k = 0; k < ArraySize; k++)
                    {
                        sum += a[irow, k] * b[k, icol];
                    }
                    M[irow, icol] = sum;
                }
        }


        ////////////////////////////////////////////////////
        //Обращение квадратной матрицы методом Жордана-Гаусса
        ////////////////////////////////////////////////////
        static void inversion(double[,] alpha)
        {
            int col, lin;
            col = 100;
            lin = 100;
            int i, j, k, t, s;
            double b, c;
            int ArraySize = 4;

            //long double a[col][lin];

            double[,] a = new double[col, lin];

            for (i = 0; i < ArraySize; i++)
            {
                for (j = 0; j < ArraySize; j++)
                {
                    a[i, j] = alpha[i, j];
                    a[i, ArraySize + j] = 0;
                }
                a[i, ArraySize + i] = 1;
            }

            for (s = 0; s < ArraySize; s++)
            {
                for (t = s; t < ArraySize; t++)
                {
                    if (a[t, s] != 0) goto beta;
                }

                Console.WriteLine("Действительных корней нет!"); // exit(1);

            beta:
                for (j = 0; j < 2 * ArraySize; j++)
                {

                    b = a[s, j];
                    a[s, j] = a[t, j];
                    a[t, j] = b;
                }

                c = 1 / a[s, s];

                for (j = 0; j < 2 * ArraySize; j++)
                {
                    a[s, j] *= c;
                }

                for (t = 0; t < ArraySize; t++)
                {
                    if (t == s) goto teta;
                    c = -a[t, s];
                    for (j = 0; j < 2 * ArraySize; j++)
                    {
                        a[t, j] += c * a[s, j];
                    }

                teta:;
                }
            }

            for (i = 0; i < ArraySize; i++)
            {
                for (j = 0; j < ArraySize; j++)
                {
                    a[i, j] = alpha[i, j];
                }
            }

            Console.WriteLine("\nОбращенная матрица .... ");

            for (i = 0; i < ArraySize; i++)
            {
                Console.WriteLine();
                //cout.precision(3);     //Два десятичных разряда
                for (j = ArraySize; j < 2 * ArraySize; j++)
                {
                    Console.Write("{0}{1}", a[i, j], j == (ArraySize - 1) ? "" : " ");
                }
            }

            double dx, dy, dz, dt;
            dx = a[0, 4];
            dy = a[1, 5];
            dz = a[2, 6];
            dt = a[3, 7];

            Console.WriteLine();

            Console.WriteLine("\ndx = " + dx + "\ndy = " + dy + "\ndz = " + dz + "\ndt = " + dt);

            double tdop = Math.Sqrt(dt);
            double vdop = Math.Sqrt(dz);
            double hdop = Math.Sqrt(dx + dy);
            double pdop = Math.Sqrt(dx + dy + dz);
            double gdop = Math.Sqrt(dx + dy + dz + dt);

            Console.WriteLine("\ngdop = " + gdop + "\npdop = " + pdop + "\nhdop = " + hdop + "\nvdop = " + vdop + "\ntdop = " + tdop);


            Console.WriteLine();

            Console.WriteLine("Проверяем результат ... ");

            for (i = 0; i < ArraySize; i++)
            {
                Console.WriteLine();
                for (j = 0; j < ArraySize; j++)
                {
                    c = 0;
                    for (k = 0; k < ArraySize; k++)
                    {
                        c += a[i, k] * a[k, j + ArraySize];
                    }
                    Console.Write("\t" + c);

                }
            }
            Console.WriteLine();
        }



        static void a()
        {

            double[,] A = new double[,] { { 0.0, 0.996, 0.087, 1.0 }, { 0.863, -0.498, 0.087, 1.0 },
       { -0.863, -0.498, 0.087, 1.0 }, { 0.0, 0.0, 1.00, 1.0 } };
            Console.WriteLine("Исходная матрица ... ");
            print(A);
            double[,] T = new double[4, 4];
            Array.Copy(A, T, 16);
            Console.WriteLine("Транспонирование ... ");
            transpositiong(T);
            print(T);

            double[,] M = new double[4, 4];
            multiplying(T, A, M);
            Console.WriteLine("Перемножаем матрицы ... ");
            print(M);

            double[,] I = new double[4, 4];
            Array.Copy(M, I, 16);
            inversion(I);
            //print(I);

            Console.WriteLine("Нажмите любую кнопку!");
            Console.ReadKey();
        }
    }
}
