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
            byte[] keyConvert = new byte[7];
            for (int i = 0; i < 7; i++)
            {
                int temp = rnd.Next(0, 2);
                keyConvert[i] = (byte)temp;
            }
            key = String.Join("", keyConvert);
        }

        
    }
}
