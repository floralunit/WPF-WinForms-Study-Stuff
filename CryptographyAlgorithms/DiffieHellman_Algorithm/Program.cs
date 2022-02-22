using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

using System.IO;

namespace DiffieHellman_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Секретный ключ пользователя А
            CngKey aKey;
            // Секретный ключ пользователя B
            CngKey bKey;
            // Открытый ключ пользователя А
            byte[] aPubKeyBlob;
            // Открытый ключ пользователя B
            byte[] bPubKeyBlob;
            // Передаваемые данные
            byte[] encryptedData;

            // Генерация секретных ключей
            aKey = CngKey.Create(CngAlgorithm.ECDiffieHellmanP256);
            bKey = CngKey.Create(CngAlgorithm.ECDiffieHellmanP256);
            // Генерация открытых ключей
            aPubKeyBlob = aKey.Export(CngKeyBlobFormat.EccPublicBlob);
            bPubKeyBlob = bKey.Export(CngKeyBlobFormat.EccPublicBlob);

            Console.WriteLine("Публичный ключ A " + Convert.ToBase64String(aPubKeyBlob));
            Console.WriteLine("Публичный ключ B " + Convert.ToBase64String(bPubKeyBlob));

            Console.WriteLine("Введите шифруемое сообщение: ");
            string message = Console.ReadLine();

            // Преобразование строки шифруемого текста в массив байт
            byte[] rawData = Encoding.UTF8.GetBytes(message);
            encryptedData = null;
            ECDiffieHellmanCng aAlgorithm = new ECDiffieHellmanCng(aKey);

            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();

            using (CngKey bPubKey = CngKey.Import(bPubKeyBlob, CngKeyBlobFormat.EccPublicBlob))
            {
                // Пользователь А создает симметричный ключ
                // путем импользования своей пары ключей и
                // открытого ключа пользователя В, вызывая
                // метод DeriveKeyMaterial()
                byte[] symmKey = aAlgorithm.DeriveKeyMaterial(bPubKey);
                Console.WriteLine("\nСимметричный ключ " + Convert.ToBase64String(symmKey));

                // Созданный симметричный ключ используется с
                // алгоритмом AES для шифрования сообщения,
                // передаваемого пользователю В

                aes.Key = symmKey;
                // Динамическая генерация начального вектора IV
                aes.GenerateIV();
                using (ICryptoTransform encryptor = aes.CreateEncryptor())
                using (MemoryStream ms = new MemoryStream())
                {

                    // создается CryptoStream и шифруются
                    // подлежащие отправке данные
                    CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write);
                    // Записывается вектор инициализации IV
                    //не шифруя
                    ms.Write(aes.IV, 0, aes.IV.Length);
                    cs.Write(rawData, 0, rawData.Length);
                    cs.Close();
                    encryptedData = ms.ToArray();
                    Console.WriteLine("Зашифрованное сообщение " + Convert.ToBase64String(encryptedData));
                }
                aes.Clear();
            }

            rawData = null;
            // Свойство BlockSize класса
            // AesCryptoServiceProvider возвращает количество
            // битов в полученном блоке.
            // Количество байтов получается делением на 8
            int nBytes = aes.BlockSize >> 3;
            // Извлекается вектор инициализации
            byte[] iv = new byte[nBytes];
            for (int i = 0; i < iv.Length; i++)
                iv[i] = encryptedData[i];
            // Создание объекта ECDiffieHellmanCng и
            // инициализация его с помощью ключей
            // пользователя В
            ECDiffieHellmanCng bAlgorithm = new ECDiffieHellmanCng(bKey);
            using (CngKey aPubKey = CngKey.Import(aPubKeyBlob, CngKeyBlobFormat.EccPublicBlob))
            {
                // Пользователь В создает симметричный ключ
                // путем импользования своей пары ключей и
                // открытого ключа пользователя А, вызывая
                // метод DeriveKeyMaterial()
                byte[] symmKey = bAlgorithm.DeriveKeyMaterial(aPubKey);
                aes.Key = symmKey;
                aes.IV = iv;
                // Дешифрование полученного сообщения с помощью
                // симметричного ключа symmKey
                using (ICryptoTransform decryptor = aes.CreateDecryptor())
                using (MemoryStream ms = new MemoryStream())
                {
                    CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write);
                    cs.Write(encryptedData, nBytes, encryptedData.Length - nBytes);
                    cs.Close();
                    rawData = ms.ToArray();
                    Console.WriteLine("\nРасщифрованное сообщение " + Encoding.UTF8.GetString(rawData));
                }
                aes.Clear();
            }

        }
    }
}
