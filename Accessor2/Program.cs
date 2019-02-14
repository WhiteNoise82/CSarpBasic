using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessor2
{
    interface IEmployee
    {
        //int a; //인터페이스는 필드를 선언 할 수 없음.
        
        string Name //string getName;     //void setName(string n);
        {
            get;
            set;
        }

       
        int Counter  //int setCounter();
        {
            get;
        }
    }

    public class Employee : IEmployee
    {
        public static int numberOgEmployees;

        private string name;
        private int counter;

        public Employee()
        {
            counter = ++counter + numberOgEmployees;
        }

        //public string getName()
        //{
        //    return name;
        //}

        //public void setName(string name)
        //{
        //    this.name = name;
        //}

        //public int getCounter()
        //{
        //    return counter;
        //}

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}


        //public int Counter
        //{
        //    get { return counter; }
        //}

        public string Name
        {
            get;
            set;
        }


        public int Counter
        {
            get { return counter; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            Console.Write("직원 수 입력: ");
            Employee.numberOgEmployees = int.Parse(Console.ReadLine());

            Employee e1 = new Employee();
            Console.Write("신입 직원의 이름을 입력하세요: ");
            n = Console.ReadLine();
            e1.Name = n;

            Console.WriteLine("- 직원 정보 -");
            Console.WriteLine("직원 번호: {0}", e1.Counter);
            Console.WriteLine("직원 이름: {0}", e1.Name);
        }
    }
}
