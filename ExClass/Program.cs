using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal myCat = new Cat("Lucas", new DateTime(2016,7,2), "Brown", Gender.male);

            Console.WriteLine("이름: " + myCat.Name);
            Console.WriteLine("나이: " + myCat.Age);
            Console.WriteLine("색: " + myCat.Color);
            Console.WriteLine("성별: " + myCat.Gender);
            Console.WriteLine(myCat.MakeSound());

            if(myCat is Cat)
            {
                Console.WriteLine((myCat as Cat).Scratch());
            }
        }
    }
}
