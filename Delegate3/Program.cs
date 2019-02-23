using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate3
{
    delegate int Compare<T>(T a, T b);

    class Program
    {
        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);
        }

        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b)  * -1;
        }

        static void BubbleSort<T>(T[] DataSet, Compare<T> Comparer)
        {
            int i = 0;
            int j = 0;
            T temp;

            for (i = 0; i < DataSet.Length - 1; i++)
            {

            }
        }

        static void Main(string[] args)
        {
        }
    }
}
