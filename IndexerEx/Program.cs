using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerEx
{
    class Cat
    {
        int i;
        public int this[int idx]    //인덱서 선언
        {
            get { return i; }
            set
            {
                i = value;
                Console.WriteLine("고양이 번호: " + idx);
            }
        }
    }

    class Dog
    {
        public int this[int idx]
        {
            get { return idx * idx; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            Console.WriteLine(dog[5]);
            Console.WriteLine(cat[55]);
            //for(int i=0;i<10;i++) Console.WriteLine(cat[i]);
            cat[55] = 10;
            Console.WriteLine(cat[55]);
            int a = cat[55];
            Console.WriteLine(a);
            

        }
    }
}
