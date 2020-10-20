using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA20201020
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] tomb = new int[10];

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(rnd.Next(10, 100));
            }
            Console.ReadKey();
        }
    }
}
