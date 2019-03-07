using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{
    //delegate int MyDelegate(int a, int b);

    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator Calc = new Calculator();
           // MyDelegate Callback;

            //Callback = new MyDelegate(Calc.Plus);
            //Console.WriteLine(Callback(3, 4));
            Console.WriteLine(Calc.Plus(3, 4)); //이 예제에서는 Delegate를 사용하지 않아도 됨.

           // Callback = new MyDelegate(Calculator.Minus);
            //Console.WriteLine(Callback(7, 5));
            Console.WriteLine(Calculator.Minus(7, 5));
        }
    }
}
