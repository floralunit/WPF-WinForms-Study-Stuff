using System;
using System.Drawing;
using System.Windows.Forms;
using WinFormsApp_FormatOutputBox_59028.Properties;

namespace WinFormsApp_FormatOutputBox
{
    class FormatOutputBox_Handling // класс форматного вывода, содержащий алгоритмы обработки
    {
        // 0. <None>
        //////////////////////////////////////////////////////////////////////
        public class Operation_None : IFormatOutputBox
        {
            //####################################################################
            public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic) //####
            {  // получаем имя текущего класса и загружаем по имени этого ресурса
                string str_class_name = this.GetType().Name; // ресурс с таким именем должен существовать!
                //pic.Image = (Image)Properties.Resources.ResourceManager.GetObject(str_class_name);
                object O = Resources.ResourceManager.GetObject(str_class_name);
                pic.Image = (Image)O;
                consoleOut.AppendText("Никаких действий не инициализировано.");
                return true;
            }
            //####################################################################
            public bool Run_Executing(int? a, int? b, ref RichTextBox consoleOut) //##########
            {
                string str = String.Format("\nДействий нет!");
                return true;
            }
            //####################################################################
        }

        ///// 1. <RSHift>
        /////////////////////////////////////////////////////////////////
        public class Operation_RShift : IFormatOutputBox
        {
            //####################################################################
            public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic) //####
            {  // получаем имя текущего класса и загружаем по имени этого ресурса
                string str_class_name = this.GetType().Name; // ресурс с таким именем должен существовать!
                                                             // pic.Image = (Image)Properties.Resources.ResourceManager.GetObject(str_class_name);
                object O = Resources.ResourceManager.GetObject(str_class_name);
                pic.Image = (Image)O;
                consoleOut.AppendText("Инициализировано действие >> (битовый сдвиг вправо)!");
                return true;
            }
            //####################################################################
            public bool Run_Executing(int? a, int? b, ref RichTextBox consoleOut) //##########
            {  // если под каждую подстановку резервируется 4 символа: {0,4}* { 1,4}+ { 2,4}
                string str = String.Format("\nВыполнение действия >>:\n{0,4}  >>{1,4}  ={2,4}", a, b, a >> b);
                consoleOut.AppendText(str);
                int? c = a>>b;
                if (Math.Abs((decimal)c) > 150)
                {
                    MessageBox.Show(
            "Ошибка #322! Число больше 150 по модулю.",
            ":(",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
                }
                return true;
            }
            //####################################################################
        }

        // 2. <RSHift_equal>
        /////////////////////////////////////////////////////////////////
        public class Operation_RShift_equal : IFormatOutputBox
        {
            //####################################################################
            public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic) //####
            {  // получаем имя текущего класса и загружаем по имени этого ресурса
                string str_class_name = this.GetType().Name; // ресурс с таким именем должен существовать!
                // pic.Image = (Image)Properties.Resources.ResourceManager.GetObject(str_class_name);
                object O = Resources.ResourceManager.GetObject(str_class_name);
                pic.Image = (Image)O;
                consoleOut.AppendText("Инициализировано действие >>= (битовый сдвиг вправо с приравниванием)!");
                return true;
            }
            //####################################################################
            public bool Run_Executing(int? a, int? b, ref RichTextBox consoleOut) //##########
            {  // если под каждую подстановку резервируется 4 символа: {0,4}* { 1,4}+ { 2,4}
                string str = String.Format("\nВыполнение действия >>=:\n{0,4}  >>={1,4}  ={2,4}", a, b, a >>= b);
                consoleOut.AppendText(str);
                int? c = a >>= b;
                if (Math.Abs((decimal)c) > 150)
                {
                    MessageBox.Show(
            "Ошибка #322! Число больше 150 по модулю.",
            ":(",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
                }
                return true;
            }
            //####################################################################
        }

        // 3. <XOR>
        /////////////////////////////////////////////////////////////////
        public class Operation_XOR : IFormatOutputBox
        {
            //####################################################################
            public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic) //####
            {  // получаем имя текущего класса и загружаем по имени этого ресурса
                string str_class_name = this.GetType().Name; // ресурс с таким именем должен существовать!
                //pic.Image = (Image)Properties.Resources.ResourceManager.GetObject(str_class_name);
                object O = Resources.ResourceManager.GetObject(str_class_name);
                pic.Image = (Image)O;
                consoleOut.AppendText("Инициализировано действие ^ (исключающее ИЛИ)!");
                return true;
            }
            //####################################################################
            public bool Run_Executing(int? a, int? b, ref RichTextBox consoleOut) //##########
            {  // если под каждую подстановку резервируется 3 символа: {0,3}+ { 1,3}+ { 2,3}
                string str = String.Format("\nВыполнение действия ^:\n{0,4}  ^{1,4}  ={2,4}", a, b, a ^ b);
                consoleOut.AppendText(str); // форматный вывод строки 
                int? c = a ^ b;
                if (Math.Abs((decimal)c) > 100)
                {
                    MessageBox.Show(
            "Ошибка #322! Число больше 100 по модулю.",
            ":(",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
                }
                return true;
            }
            //####################################################################
        }

        // 4. <XOR_equal>
        /////////////////////////////////////////////////////////////////
        public class Operation_XOR_equal : IFormatOutputBox
        {
            //####################################################################
            public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic) //####
            {  // получаем имя текущего класса и загружаем по имени этого ресурса
                string str_class_name = this.GetType().Name; // ресурс с таким именем должен существовать!
                // pic.Image = (Image)Properties.Resources.ResourceManager.GetObject(str_class_name);
                object O = Resources.ResourceManager.GetObject(str_class_name);
                pic.Image = (Image)O;
                consoleOut.AppendText("Инициализировано действие ^= (исключающее ИЛИ с приравниванием)!");
                return true;
            }
            //####################################################################
            public bool Run_Executing(int? a, int? b, ref RichTextBox consoleOut) //##########
            {  // если под каждую подстановку резервируется 4 символа: {0,4}* { 1,4}+ { 2,4}
                string str = String.Format("\nВыполнение действия ^=:\n{0,4}  ^={1,4}  ={2,4}", a, b, a ^= b);
                consoleOut.AppendText(str);
                int? c = a ^= b;
                if (Math.Abs((decimal)c) > 100)
                {
                    MessageBox.Show(
            "Ошибка #322! Число больше 100 по модулю.",
            ":(",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
                }
                return true;
            }
            //####################################################################
        }
    }

}

