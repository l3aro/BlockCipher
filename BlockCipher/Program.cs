using System;

namespace BlockCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockCipher BlockCipher = new BlockCipher();

            Console.Write("Nhap chuoi can ma hoa: ");
            string plainText = Console.ReadLine();

            while (plainText == "")
            {
                Console.Write("Chuoi vua nhap khong co ki tu nao! Nhap lai: ");
                plainText = Console.ReadLine();
            }

            string key = BlockCipher.GenerateNewKey();

            string encrypted = BlockCipher.Encrypt(plainText, key);
            Console.WriteLine("Chuoi da ma hoa la:\n{0}", encrypted);

            string decrypted = BlockCipher.Decrypt(encrypted, key);
            Console.WriteLine("Chuoi da giai ma la:\n{0}", decrypted);           

            Console.ReadKey();
        }
    }
}
