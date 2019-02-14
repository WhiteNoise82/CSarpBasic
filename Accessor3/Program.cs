using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessor3
{
    abstract class Shape    //도형 추상클래스
    {
        public abstract double Area
        {
            get;
            set;
        }
    }

    class Square : Shape
    {
        public double Side;

        public Square(double side)
        {
            this.Side = side;
        }

        public override double Area
        {
            get { return Side * Side; }
            set { Side = Math.Sqrt(value); }
        }
    }

    class Cube : Shape
    {
        public double Side;

        public Cube(double side)
        {
            this.Side = side;
        }

        public override double Area
        {
            get { return 6* Side * Side; }
            set { Side = Math.Sqrt(value / 6); }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            Square square = new Square(side);
            Cube cube = new Cube(side);

            Console.WriteLine("정사각형의 면적: {0}", square.Area);
            Console.WriteLine("정사각형의 면적: {0}", cube.Area);

            double area = double.Parse(Console.ReadLine());
            square.Area = area;
            cube.Area = area;
            Console.WriteLine("정사각형의 변: {0}", square.Side);
            Console.WriteLine("정사각형의 변: {0}", cube.Side);

        }
    }
}
