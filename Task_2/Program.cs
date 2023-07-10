using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_2
{


    internal class Program
    {
        static void MyTask1()
        {
            Console.WriteLine("MyTask1: запущен.");
            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(10);
                Console.Write("+");
            }
            Console.WriteLine("MyTask1: завершен.");
        }

        static void MyTask2()
        {


            Console.WriteLine("MyTask2: запущен.");
            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(10);
                Console.Write("-");
            }
            Console.WriteLine("MyTask2: завершен.");
        }


        static void Main(string[] args)
        {
            Task.Factory.StartNew(() => Parallel.Invoke(MyTask1, MyTask2));

            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(10);
                Console.Write("%");
            }

            Console.ReadKey();
        }
    }
}
