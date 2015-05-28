using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    static class Devs1Class
    {
        public static void PrintSurname()
        {
            Console.WriteLine("Filchenkov");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vika");
            Devs1Class.PrintSurname();
        }
    }
}
