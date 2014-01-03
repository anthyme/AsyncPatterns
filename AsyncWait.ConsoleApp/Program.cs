using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncWait.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();

            Console.WriteLine("- Basic task 1");
            BasicOutput.Task1();
            Console.ReadKey();

            Console.WriteLine("- Basic task 2");
            BasicOutput.Task2();
            Console.ReadKey();

            Console.WriteLine("- Basic async");
            BasicOutput.Async();
            Console.ReadKey();



            Console.ReadKey();

            Console.WriteLine("- Using task 1");
            UsingOutput.Task1();
            Console.ReadKey();

            Console.WriteLine("- Using task 2");
            UsingOutput.Task2();
            Console.ReadKey();

            Console.WriteLine("- Using async");
            UsingOutput.Async();
            Console.ReadKey();



            Console.ReadKey();

            Console.WriteLine("- Using Exception task 1");
            UsingExceptionOutput.Task1();
            Console.ReadKey();

            Console.WriteLine("- Using Exception task 2");
            UsingExceptionOutput.Task2();
            Console.ReadKey();

            Console.WriteLine("- Using Exception task 3");
            UsingExceptionOutput.Task3();
            Console.ReadKey();

            Console.WriteLine("- Using Exception task 4");
            UsingExceptionOutput.Task4();
            Console.ReadKey();

            Console.WriteLine("- Using Exception async");
            UsingExceptionOutput.Async();
            Console.ReadKey();

            Console.WriteLine("- Using Exception async 2");
            UsingExceptionOutput.Async2();
            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
