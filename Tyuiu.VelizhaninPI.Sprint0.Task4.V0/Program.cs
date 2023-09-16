using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VelizhaninPI.Sprint0.Task4.V0.Lib;
using Tyuiu.VelizhaninPI.Sprint0.Task4.V0.Test;

namespace Tyuiu.VelizhaninPI.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 5));
            Console.ReadKey();
            Console.WriteLine(DataService.Subtraction(15, 5));
            Console.ReadKey();
            Console.WriteLine(DataService.Multiplication(10, 10));
            Console.ReadKey();
            Console.WriteLine(DataService.Division(5, 5));
            Console.ReadKey();

        }
    }
}
