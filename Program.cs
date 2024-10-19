using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите a:");
            string input = Console.ReadLine();
            a = int.Parse(input);
            Console.WriteLine(a * a);
        }
    }
}
