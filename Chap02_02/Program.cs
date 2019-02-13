using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //부동 소수점 float 4byte 상수 뒤에 접미사 'f'를 붙여야 한다.
            //부동 소수점 double 8byte
            //IEEE754 부동소수점 표현방식을 따른다.
            float f = 3.14f;   
            double d = 3.14;

            //문자, 문자열
            //문자는 작은따옴표 ' '를 사용
            //문자열은 큰따옴표 " "를 사용
            char c = '김';
            string s = "안녕, 권오성";

            //논리 자료형 boolean
            bool b1 = true;
            bool b2 = false;
            bool b3 = b1 && b2;


            Console.WriteLine(f / 3.1f);
            Console.WriteLine(d / 3.1);

            Console.WriteLine(c);
            Console.WriteLine(s);

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
        }
    }
}
