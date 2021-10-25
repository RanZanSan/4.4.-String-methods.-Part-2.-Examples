using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToLowerAndToUpperExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Some String";
            Console.WriteLine(s.ToUpper()); //SOME STRING
            Console.WriteLine(s.ToLower()); //some string
            Console.ReadKey();
        }
    }
}