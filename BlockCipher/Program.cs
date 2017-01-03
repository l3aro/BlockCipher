using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockCipher BlockCipher = new BlockCipher();

            Console.Write(BlockCipher.key);

            Console.ReadKey();
        }
    }
}
