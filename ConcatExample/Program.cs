using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "a b c ";
            string s2 = "d e f ";
            string s3 = "g h i";
            Console.WriteLine(string.Concat(s1, s2, s3)); // "a b c d e f g h i"
            Console.ReadKey();
        }
    }
}