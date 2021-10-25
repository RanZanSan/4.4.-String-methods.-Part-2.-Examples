using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "#csharp essentials##";
            string t = s.Trim('#'); // удаляет в начале и в конце символ #
            Console.WriteLine(t); // "csharp essentials"
            Console.ReadKey();
        }
    }
}