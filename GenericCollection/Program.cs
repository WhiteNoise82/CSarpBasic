using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List<T>
            List<int> list = new List<int>();

            for (int i = 0; i < 20; i++) list.Add(i + 1);
            Console.WriteLine("- List<> -");
            foreach (int i in list) Console.WriteLine("{0}", i);
            #endregion

            #region Stack<T>
            Stack<int> stack = new Stack<int>();

            object a = 0;
            for (int i = 0; i < 20; i++) stack.Push(i * 2);
            Console.WriteLine("- Stack -");
            a = stack.Peek();
            while (stack.Count != 0) Console.WriteLine(stack.Pop());
            Console.WriteLine(a);
            while (stack.Count != 0) Console.WriteLine(stack.Pop());
            #endregion

            #region Queue<T>
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < 20; i++) queue.Enqueue(i * 2);
            Console.WriteLine("- Queue -");
            a = queue.Peek();
            while (queue.Count != 0) Console.WriteLine(queue.Dequeue());
            Console.WriteLine(a);
            while (queue.Count != 0) Console.WriteLine(queue.Dequeue());

            #endregion

            #region Dictionary<TKey, TValue>
            Dictionary<double, string> dictionary = new Dictionary<double, string>();

            dictionary[1.0] = "버전 1.0";
            dictionary[1.1] = "버전 1.1";
            dictionary[2.0] = "버전 2.0";
            dictionary[2.2] = "버전 2.2";
            dictionary[2.9] = "버전 2.9";

            dictionary.Add(2.3, "버전 2.3");

            Console.WriteLine("- Hashtable -");

            Console.WriteLine(dictionary[2.3]);
            Console.WriteLine(dictionary.Contains<double, string>(2.2));

            #endregion
        }
    }
}
