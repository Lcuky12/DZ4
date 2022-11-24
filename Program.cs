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
            int row = 3;
            int pictures = 52;
            int completedPages = pictures / row;
            int remainder = pictures % row;
            Console.WriteLine(" Заполненных рядов " + completedPages);
            Console.WriteLine(" Осталось картинок " + remainder);
        }
    }
}
