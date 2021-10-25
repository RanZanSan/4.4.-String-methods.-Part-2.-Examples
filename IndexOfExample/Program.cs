using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "i like my house and my car";
            int index = s.IndexOf("my"); // найдет индекс начала подстроки "my" в строке s
            Console.WriteLine(index); // 7
            Console.WriteLine(s.IndexOf('x')); // выведет -1, т.к. в исходной строке нет символа x
            Console.ReadKey();
        }
    }
}