using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProg1
{
    class Human<T>  //제네릭 클래스
        //where T : class
    {
        private T Name;
        public Human(T name)
        {
            this.Name = name;
        }

        public T IsName
        {
            get { return Name; }
            set { Name = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human<string> human = new Human<string>(Console.ReadLine());
            if (int.TryParse(human.IsName, out int result))
            {
                Console.WriteLine(result);
            }
        }
    }
}
