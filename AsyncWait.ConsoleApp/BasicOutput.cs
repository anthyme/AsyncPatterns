using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncWait.ConsoleApp
{
    class BasicOutput
    {
        public static void Task1()
        {
            Console.WriteLine("Task start");
            Work.WorkAsync();
            Console.WriteLine("Task end");
        }

        public static void Task2()
        {
            Console.WriteLine("Task start");
            Work.WorkAsync().ContinueWith(t =>
            {
                Console.WriteLine("Task end:" + t.Result);
            });
        }

        public static async void Async()
        {
            Console.WriteLine("Out task start");
            var result = await Work.WorkAsync();
            Console.WriteLine("Out task end:" + result);
        }
    }
}
