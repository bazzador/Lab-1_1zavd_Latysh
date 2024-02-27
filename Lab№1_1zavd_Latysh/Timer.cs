using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_1_1zavd_Latysh
{
    class Timer
    {
        public static void Method1()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(200);
                Console.WriteLine($"Робота метода 1! Номер потоку:{Thread.CurrentThread.ManagedThreadId}");
            }
            
        }
        public static void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine($"Робота метода 2! Номер потоку:{Thread.CurrentThread.ManagedThreadId}");
            }
        }
    }
}
