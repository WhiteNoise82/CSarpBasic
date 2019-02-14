using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[4] { 55, 11, -4, 5 };
            arr[1] = new int[] { 15, 20, 30 };
            arr[2] = new int[2] { 10, 20 };

            foreach(int[] i in arr)
            {
                int k = 1;
                Console.Write("길이: {0}, ", i.Length);
                foreach(int j in i)
                {
                    Console.Write("원소 [{0}]: {1} ", k, j);
                    k++;
                }
                Console.WriteLine();
            }

        }
    }
}
