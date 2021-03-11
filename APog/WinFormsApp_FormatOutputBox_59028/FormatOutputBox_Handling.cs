using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
                                                             // pic.Image = (Image)Properties.Resources.ResourceManager.GetObject(str_class_name);
                consoleOut.AppendText("Никаких действий не инициализировано.");
                return true;
            }
            //####################################################################
            public bool Run_Executing(int? a, int? b, ref RichTextBox consoleOut) //##########
            {
                string str = String.Format("\nВыполнение действия \"0\"");
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
                //pic.Image = (Image)Properties.Resources.ResourceManager.GetObject(str_class_name);
                consoleOut.AppendText("Инициализировано действие >>!");
                return true;
            }
            //####################################################################
            public bool Run_Executing(int? a, int? b, ref RichTextBox consoleOut) //##########
            {  // если под каждую подстановку резервируется 4 символа: {0,4}* { 1,4}+ { 2,4}
                string str = String.Format("\nВыполнение действия \"2\":\n{0}^ { 1} = { 2}", a, b, a >> b);
                consoleOut.AppendText(str);
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
                consoleOut.AppendText("Инициализировано действие >>=!");
                return true;
            }
            //####################################################################
            public bool Run_Executing(int? a, int? b, ref RichTextBox consoleOut) //##########
            {  // если под каждую подстановку резервируется 4 символа: {0,4}* { 1,4}+ { 2,4}
               string str = String.Format("\nВыполнение действия \"2\":\n{0}>>={ 1} = { 2}", a, b, a >>= b);
                consoleOut.AppendText(str);
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
                consoleOut.AppendText("Инициализировано действие ^!");
                return true;
            }
            //####################################################################
            public bool Run_Executing(int? a, int? b, ref RichTextBox consoleOut) //##########
            {  // если под каждую подстановку резервируется 3 символа: {0,3}+ { 1,3}+ { 2,3}
                string str = String.Format("\nВыполнение действия \"1\":\n{0}+ { 1} = { 2}", a, b, a ^ b);
                consoleOut.AppendText(str); // форматный вывод строки 
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
                consoleOut.AppendText("Инициализировано действие ^=!");
                return true;
            }
            //####################################################################
            public bool Run_Executing(int? a, int? b, ref RichTextBox consoleOut) //##########
            {  // если под каждую подстановку резервируется 4 символа: {0,4}* { 1,4}+ { 2,4}
                string str = String.Format("\nВыполнение действия \"2\":\n{0}* { 1} = { 2}", a, b, a ^= b);
                consoleOut.AppendText(str);
                return true;
            }
            //####################################################################
        }
    }

}
    
