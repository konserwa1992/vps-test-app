using System;
using System.Threading;

namespace vps_test_app
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Thread.Sleep(1000);
                Console.WriteLine("TEST World!");
            }
        }
    }
}
