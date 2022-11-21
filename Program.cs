using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 52;
            int c = b / a;
            int d = b % a;
            Console.WriteLine(" Заполненных рядов " + c);
            Console.WriteLine(" Осталось картинок " + d);
        }
    }
}
