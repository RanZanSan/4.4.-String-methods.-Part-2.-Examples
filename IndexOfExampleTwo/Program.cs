using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfExampleTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "i like my house and my car";
            int index = s.IndexOf("like", 7); // найдет -1, т.к. в строке после 7 индекса нет строки "like"
            Console.WriteLine(index); // -1
            Console.ReadKey();
        }
    }
}