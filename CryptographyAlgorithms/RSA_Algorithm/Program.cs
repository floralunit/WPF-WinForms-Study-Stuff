using System;
using System.Security.Cryptography;
using System.Text;

namespace RSA_Alhotithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg;
            RSAParameters privateKey; //определение переменной для приватного ключа
            RSAParameters publicKey; //определение переменной для публичного ключа

            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(); //создание объекта RSA

            privateKey = RSA.ExportParameters(true);
            publicKey = RSA.ExportParameters(false);
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            Console.WriteLine("Введите строку, которую надо зашифровать:");
            msg = Console.ReadLine();
            Console.WriteLine($"Зашифровать: {msg}");
            //шифрование сообщения при помощи открытого ключа
            byte[] encBytes = RSAEncrypt(byteConverter.GetBytes(msg), publicKey, false);
            string encrypt = Convert.ToBase64String(encBytes);
            Console.WriteLine("Шифрование: " + encrypt);
            //расшифровка сообщения при помощи приватного ключа
            byte[] decBytes = RSADecrypt(encBytes, privateKey, false);
            Console.WriteLine("Дешифрование: " + byteConverter.GetString(decBytes));
            Console.ReadKey();
        }

        static public byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            //создание объекта RSA
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            //импорт информации о RSA ключе
            RSA.ImportParameters(RSAKeyInfo);
            //шифрование
            return RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
        }
        static public byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            //создание объекта RSA
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            //импорт информации о RSA ключе
            RSA.ImportParameters(RSAKeyInfo);
            //расшифровка 
            return RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
        }
    }
}
