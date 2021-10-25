using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimExampleTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "    csharp essentials    ";
            string t = s.Trim(); // удаляет пробелы в начале и в конце
            Console.WriteLine(t); // "csharp essentials"
            Console.ReadKey();
        }
    }
}