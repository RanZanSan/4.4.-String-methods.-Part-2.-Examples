using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatExampleTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "a b ", "с d ", "e f ", "g h " };
            Console.WriteLine(string.Concat(array)); // "a b c d e f g h i "
            Console.ReadKey();
        }
    }
}