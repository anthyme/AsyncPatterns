using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncWait.ConsoleApp
{
    class Work
    {
        public static Task<string> WorkAsync()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Inside task start");
                Thread.Sleep(3000);
                Console.WriteLine("Inside task end");
                return "hello";
            });
        }

        public static Task<string> WorkExceptionAsync()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Inside task start");
                Thread.Sleep(3000);
                Console.WriteLine("throw exception");
                throw new Exception();
                Console.WriteLine("Inside task end");
                return "hello";
            });
        }
    }
}
