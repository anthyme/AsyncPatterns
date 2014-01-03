using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncWait.ConsoleApp
{
    class UsingExceptionOutput
    {
        public static void Task1()
        {
            using (new DisposableOutput())
            {
                Work.WorkExceptionAsync();
            }
        }

        public static void Task2()
        {
            var output = new DisposableOutput();
            Work.WorkExceptionAsync().ContinueWith(t =>
            {
                var result = t.Result;
                output.Dispose();
            });
        }

        public static void Task3()
        {
            var output = new DisposableOutput();
            Work.WorkExceptionAsync().ContinueWith(t =>
            {
                var result = t.Result;
            }).ContinueWith(t =>
            {
                output.Dispose();
            });
        }

        public static void Task4()
        {
            var output = new DisposableOutput();
            Work.WorkExceptionAsync().ContinueWith(t =>
            {
                if (t.Exception == null)
                {
                    var result = t.Result;
                }
                output.Dispose();
            });
        }

        public static async void Async()
        {
            using (new DisposableOutput())
            {
                var result = await Work.WorkExceptionAsync();
            }
        }

        public static async void Async2()
        {
            using (new DisposableOutput())
            {
                try
                {
                    var result = await Work.WorkExceptionAsync();
                }
                catch (Exception ex)
                {
                    
                }
            }
        }
    }
}
