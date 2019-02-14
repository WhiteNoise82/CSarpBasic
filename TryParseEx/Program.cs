using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int outValue;
            double ostDouble;


            bool result = int.TryParse(Console.ReadLine(), out outValue);
            Console.WriteLine(result);
            Console.WriteLine(outValue);

            result = double.TryParse(Console.ReadLine(), out ostDouble);
            Console.WriteLine(result);
            Console.WriteLine(ostDouble);

        }
    }
}
