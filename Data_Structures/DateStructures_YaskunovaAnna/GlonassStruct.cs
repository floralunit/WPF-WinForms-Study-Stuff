using System;
using System.Collections.Generic;
using System.Text;

namespace Massives
//Более универсальная программа определения фактора геометрического снижения точности ГЛОНАСС (использование структур)
{
    class GlonassStruct
    {
        static void print(double[,] alpha)
        {
            int ArraySize = 4;

            for (int i = 0; i < ArraySize; i++)
            {
                for (int j = 0; j < ArraySize; j++)
                {
                    Console.Write("\t{0:##.###}", alpha[i, j]);
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

                Console.WriteLine("Действительных корней нет!");

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
                for (j = ArraySize; j < 2 * ArraySize; j++)
                {
                    Console.Write("\t{0:##.###}", a[i, j]);
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
                    Console.Write("\t{0:##.###}", c);
                }
            }
            Console.WriteLine();
        }


        /// ////////////
        /// Структура декартовых координат
        struct Cartesian
        {
            public double x;
            public double y;
            public double z;
        }

        //Заполняем исходную матрицу значениями
        static void fill_satellite(double[,] alpha)
        {
            double x1, x2, x3, x4, y1, y2, y3, y4, z1, z2, z3, z4, Rx, Ry, Rz;

            int ArraySize = 4;
            Cartesian rover;

            // Координаты потребителя
            Rx = -730000;
            Ry = -5440000;
            Rz = 3230000;

            // Координаты потребителя
            rover.x = Rx;
            rover.y = Ry;
            rover.z = Rz;

            //Координаты спутников
            Cartesian[] satellite = new Cartesian[ArraySize];
            //Компоненты единичного вектора от спутников к наблюдателю
            Cartesian[] s = new Cartesian[ArraySize];

            x1 = 15524471.175; y1 = -16649826.222; z1 = 13512272.387;  // Координаты первого спутника
            x2 = -2304058.534; y2 = -23287906.465; z2 = 11917038.105;  // Координаты второго спутника
            x3 = 16680243.357; y3 = -3069625.561; z3 = 20378551.047;  // Координаты третьего спутника
            x4 = -14799931.395; y4 = -21425358.24; z4 = 6069947.224;   // Координаты четвертого спутника

            satellite[0].x = x1; satellite[0].y = y1; satellite[0].z = z1;  // Координаты первого спутника
            satellite[1].x = x2; satellite[1].y = y2; satellite[1].z = z2;  // Координаты второго спутника
            satellite[2].x = x3; satellite[2].y = y3; satellite[2].z = z3;  // Координаты третьего спутника
            satellite[3].x = x4; satellite[3].y = y4; satellite[3].z = z4;  // Координаты четвертого спутника


            //Растояния от наблюдателя до i-го спутника
            double[] R = new double[ArraySize];

            int i;
            for (i = 0; i < ArraySize; i++)
            {
                R[i] = Math.Sqrt(Math.Pow((satellite[i].x - rover.x), 2) + Math.Pow((satellite[i].y - rover.y),
     2) + Math.Pow((satellite[i].z - rover.z), 2));
            }

            for (i = 0; i < ArraySize; i++)
            {
                s[i].x = (satellite[i].x - rover.x) / R[i];
                s[i].y = (satellite[i].y - rover.y) / R[i];
                s[i].z = (satellite[i].z - rover.z) / R[i];
            }

            //Исходная матрица

            for (i = 0; i < ArraySize; i++)
            {
                alpha[i, 0] = s[i].x;
                alpha[i, 1] = s[i].y;
                alpha[i, 2] = s[i].z;
                alpha[i, 3] = 1;
            }
        }


        static void a()
        {
            double[,] A = new double[4, 4];
            //Заполняем исходную матрицу
            fill_satellite(A);

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

            Console.WriteLine("Нажмите любую кнопку!");
            Console.ReadKey();
        }
    }
}
