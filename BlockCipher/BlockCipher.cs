using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCipher
{
    class BlockCipher
    {
        private string key;

        public BlockCipher()
        {
            Random rnd = new Random();
            byte[] keyConvert = new byte[8];
            keyConvert[0] = 0;
            for (int i = 1; i < 8; i++)
            {
                int temp = rnd.Next(0, 2); // random 0 or 1
                keyConvert[i] = (byte)temp;
            }
            key = String.Join("", keyConvert);
            key = "00101101"; // for testing purpose
        }
               
        private static string ASCIIToBinary(string asciiString)
        {
            byte[] data = Encoding.ASCII.GetBytes(asciiString);
            return string.Join(" ", data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
        }

        private static string BinaryToASCII(string binaryString)
        {
            string[] binaryStringData = binaryString.Split(' ');
            byte[] resultData = new byte[binaryStringData.Length];

            for (int i = 0; i < binaryStringData.Length; i++)
            { 
                resultData[i] = Convert.ToByte(binaryStringData[i], 2);
            }

            return Encoding.ASCII.GetString(resultData);
        }
        

        public string Encrypt(string plainText)
        {
            //Convert plain text to Binary
            plainText = ASCIIToBinary(plainText);
            //bind binary plain text into an array of string
            string[] plainTextData = plainText.Split(' ');
            //innate a variable to hold result
            string result = "";

            for (int i = 0; i < plainTextData.Length; i++)
            {
                //for each character, we xor with key data
                byte[] tempResult = new byte[8];

                for (int j = 0; j < 8; j++)
                {
                    int x = int.Parse(plainTextData[i][j].ToString());
                    int y = int.Parse(key[j].ToString());
                    tempResult[j] = (byte)(x + y);
                    if (tempResult[j] == 2)
                    {
                        tempResult[j] = 0;
                    }
                }
                result += string.Join("", tempResult);
                result += " ";
            }
            //after the loop, we have a space that need to trim at the end of the result string
            result = result.TrimEnd();
            //now change the result, that in binary string, to ascii string
            result = BinaryToASCII(result);
            
            return result;
        }
    }
}
