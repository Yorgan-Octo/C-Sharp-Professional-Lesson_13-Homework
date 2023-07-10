using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] ints = new int[1_000_000];

            Action<int> action = (i) =>
            {
                ints[i] = new Random().Next(1000);
            };

            Parallel.For(0, ints.Length, action);


            var negatives = ints.AsParallel().AsOrdered().Where(element => (element % 2) != 0);


            foreach (int element in negatives)
                Console.Write(element + " ");



            Console.ReadKey();
        }
    }
}
