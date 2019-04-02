using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate6
{
    class Program
    {
        delegate int MyDelegate(string s);

        void Test()
        {
            MyDelegate m = new MyDelegate(StringToInt);

            Run(m);
        }

        int StringToInt(string s)
        {
            return int.Parse(s);
        }

        void Run(MyDelegate m)
        {
            int i = m.Invoke("123");

            Console.WriteLine(i);
        }

        static void Main(string[] args)
        {
            new Program().Test();
        }
    }
}
