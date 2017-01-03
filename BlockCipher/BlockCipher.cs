using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCipher
{
    class BlockCipher
    {
        public string key;

        public BlockCipher()
        {
            Random rnd = new Random();
            byte[] keyConvert = new byte[8];
            keyConvert[0] = 0;
            for (int i = 1; i < 8; i++)
            {
                int temp = rnd.Next(0, 2);
                keyConvert[i] = (byte)temp;
            }
            key = String.Join("", keyConvert);
        }

        

        public static string ASCIIToBinary(string asciiString)
        {
            byte[] data = Encoding.ASCII.GetBytes(asciiString);
            return string.Join(" ", data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
        }

        public static string BinaryToASCII(string binaryString)
        {
            string[] binaryStringData = binaryString.Split(' ');
            byte[] resultData = new byte[binaryStringData.Length];

            for (int i = 0; i < binaryStringData.Length; i++)
            { 
                resultData[i] = Convert.ToByte(binaryStringData[i], 2);
            }

            return Encoding.ASCII.GetString(resultData);
        }

        //public string Encrypt(string plaintext)
        //{

        //}
    }
}
