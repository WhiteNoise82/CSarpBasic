using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] locker = new int[5];
            int[,] nums = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };

            for(int i = 0; i < locker.Length; i++)
            {
                locker[i] = i + 1;
            }

            for (int i = 0; i < locker.Length; i++)
            {
                Console.Write("{0} ", locker[i]);
            }
            Console.WriteLine();

            foreach(int loc in locker)
            {
                Console.Write("{0} ", loc);
            }
            Console.WriteLine();

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write("{0} ", nums[i, j]);
                }
            }
            Console.WriteLine();

            foreach (int i in nums)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
