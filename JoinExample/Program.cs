using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "день", "месяц", "год" };
            Console.WriteLine(string.Join("-", array)); // "день-месяц-год"
            Console.ReadKey();
        }
    }
}