using System;

namespace ClassLib_Calc_59028
{
    public class Calculator
    {

        public static string rightdraf(int first_num, int second_num)
        {
            string str_ret = "Результат вычисления: ";
            int numb = first_num >> second_num;
            if (Math.Abs(numb) > 150)
                str_ret += "\nОшибка #322! Число больше 150 по модулю.";
            else
                str_ret += numb.ToString();
            return str_ret;
        }
        public static string rightdraf_equal(int first_num, int second_num)
        {
            string str_ret = "Результат вычисления: ";
            int numb = first_num >>= second_num;
            if (Math.Abs(numb) > 150)
                str_ret += "\nОшибка #322! Число больше 150 по модулю.";
            else
                str_ret += numb.ToString();
            return str_ret;
        }
        public static string galka(int first_num, int second_num)
        {
            string str_ret = "Результат вычисления: ";
            int numb = first_num | second_num;
            if (Math.Abs(numb) > 100)
                str_ret += "\nОшибка #322! Число больше 100 по модулю.";
            else
                str_ret += numb.ToString();
            return str_ret;
        }
        public static string galka_equal(int first_num, int second_num)
        {
            string str_ret = "Результат вычисления: ";
            int numb = first_num |= second_num;
            if (Math.Abs(numb) > 100)
                str_ret += "\nОшибка #322! Число больше 100 по модулю.";
            else
                str_ret += numb.ToString();
            return str_ret;
        }

    }
}
