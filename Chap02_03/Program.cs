using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 55;         // 값 형식 변수, 스택(stack) 메모리 공간 사용,
                                //중괄호가 끝나는 시점에 메모리에서 제거
            short d = 3000;
            sbyte e = 127;
            int f;
            sbyte g;
            float h = 3.141592f;
            object b = "KWON";  // 참조 형식 변수, 힙(heap) 메모리 공간 사용,
                                //Garbage Collector에서 제거

            object c = 100;     // 참조 형식 변수, 좀더 유연한 프로그램 작성시 사용

            f = e;
            g = (sbyte)d;       //2바이트 자료형인 short을 sbyte 자료형으로
                                //강재 형 변환 하였을때 3000은 sbyte의 표현범위를
                                //넘어서기 때문에 overflow가 발생한다.


            Console.WriteLine("{0} {1} {2} {3} {4}", a, d, e, f, g);

            f = (int)h;         //h의 소숫점 부분이 잘려나감.

            Console.WriteLine("{0} {1}", h, f);

            Console.WriteLine("{0} {1} {2}", a, b, c);
            Console.WriteLine("{2} {0} {1}", a, b, c);


        }
    }
}
