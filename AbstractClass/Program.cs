using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Employee
    {
        protected string name; //추상클래스는 인터페이스와 달리 필드 선언이 가능
        public Employee(string name)    //생성자
        {
            this.name = name;
        }

        public abstract void Display();
    }

    public class Manager : Employee
    {
        public Manager(string name) : base(name) //base키워드는 부모 클래스의 생성자를 호출
        {
        }

        public override void Display()  //추상메소드 재정의
        {
            Console.WriteLine("성명은 : " + name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager("권오성");

            m1.Display();

            //Employee e1 = new Employee("권오현");  //추상클래스는 자신의 인스턴스를 생성 할 수 없다.
            Employee e1 = new Manager("권오현");
            e1.Display();
        }
    }
}
