using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessor
{
    class Test
    {
        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.X = 13;

            Console.WriteLine(test.X);

        }
    }
}
