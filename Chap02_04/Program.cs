/*
 * 작성일자 : 2019년 01월 24일
 * 작성자 : 권오성
 * 학습내용 : 열거식, var 등
 * 열거식 : 사용되는 값을 정의함으로써 예상치 못한 값의 입력의 경우를 제거
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap02_04
{
    class Program
    {
        enum Human { Warrior, Wizard = 55, Thief }   //열거식
        static void Main(string[] args)
        {
            var x = -55.7;  // 변수를 선언하고 값을 할당하는 순간에 var의 형을 결정한다.
            //var y;        // error - 반드시 변수를 선언할때 값을 할당(초기화) 해야한다.
            object a = 3.7; // object는 하나의 자료형으로 선언 이후에도 자유롭게 여러형의 자료를 사용가능.
                            // 따라서, 선언과 동시에 초기화를 하지 않아도 괜찮다.
                            // var는 초기화 하는 순간에 변수의 자료형이 결정되어 초기값의 자료형으로 고정된다.
            object b;

            Console.WriteLine("{0} {1}", x.GetType(), a.GetType());

            a = 5;

            Console.WriteLine("{0} {1}", x.GetType(), a.GetType());

            //Console.WriteLine("{0} {1}", x, a);

            //Console.WriteLine((int)Human.Wizard);
            //Console.WriteLine((int)Human.Thief);
            //Console.WriteLine((int)Human.Warrior);


        }
    }
}
