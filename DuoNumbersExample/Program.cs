using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuoNumbersExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Example(12312, 34);
            Example(34243,0);
            Example(0, 0);
            Example2(13, 0);
        }

        static void Example(int a, int b)
        {
            DuoNumbers duo = new DuoNumbers(a, b);
            duo.PrintAll();
            Console.WriteLine("\n\n");
        }
        static void Example2(int a, int b)
        {
            DuoNumbers duo = new DuoNumbers(a, b);
            duo.PrintDiv();
            duo.PrintAdd();
            duo.PrintAll();
        }
    }
}
