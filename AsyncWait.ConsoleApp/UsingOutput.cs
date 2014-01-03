using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncWait.ConsoleApp
{
    class DisposableOutput : IDisposable
    {
        public DisposableOutput()
        {
            Console.WriteLine("Using start");
        }

        public void Dispose()
        {
            Console.WriteLine("Using end");
        }
    }


    class UsingOutput
    {
        public static void Task1()
        {
            using (new DisposableOutput())
            {
                Work.WorkAsync();
            }
        }

        public static void Task2()
        {
            var output = new DisposableOutput();
            Work.WorkAsync().ContinueWith(t =>
            {
                var result = t.Result;
                output.Dispose();
            });
        }

        public static async void Async()
        {
            using (new DisposableOutput())
            {
                var result = await Work.WorkAsync();
            }
        }
    }
}
