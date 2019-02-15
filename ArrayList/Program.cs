using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList
            ArrayList arrList = new ArrayList();

            for (int i = 0; i < 20; i++) arrList.Add(i + 1);
            Console.WriteLine("- ArrayList -");
            arrList.RemoveAt(2);
            arrList.Remove(5);
            arrList.Reverse();
            foreach (int i in arrList) Console.WriteLine("{0}", i);
            #endregion

            #region Stack
            Stack stack = new Stack();

            object a = 0;
            for (int i = 0; i < 20; i++) stack.Push(i * 2);
            Console.WriteLine("- Stack -");
            a=stack.Peek();
            while (stack.Count != 0) Console.WriteLine(stack.Pop());
            Console.WriteLine(a);
            while (stack.Count != 0) Console.WriteLine(stack.Pop());
            #endregion

            #region Queue
            Queue queue = new Queue();

            for (int i = 0; i < 20; i++) queue.Enqueue(i * 2);
            Console.WriteLine("- Queue -");
            a = queue.Peek();
            while (queue.Count != 0) Console.WriteLine(queue.Dequeue());
            Console.WriteLine(a);
            while (queue.Count != 0) Console.WriteLine(queue.Dequeue());
            #endregion

            #region Hashtable
            Hashtable hashtable = new Hashtable();

            hashtable[1.0] = "버전 1.0";
            hashtable[1.1] = "버전 1.1";
            hashtable[2.0] = "버전 2.0";
            hashtable[2.2] = "버전 2.2";
            hashtable[2.9] = "버전 2.9";

            hashtable.Add(2.3, "버전 2.3");
            
            Console.WriteLine("- Hashtable -");

            Console.WriteLine(hashtable[2.3]);
            Console.WriteLine(hashtable.Contains(2.2));
            #endregion
        }
    }
}
