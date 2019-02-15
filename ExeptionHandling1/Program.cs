using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling1
{
    class Program
    {
        static void Main(string[] args)
        {

            outer:
            try
            {
                Console.Write("첫번째 정수를 입력: ");
                int firstNum = int.Parse(Console.ReadLine());
                Console.Write("두번째 정수를 입력: ");
                int secondNum = int.Parse(Console.ReadLine());

                int result = firstNum / secondNum;
                Console.WriteLine("결과: {0}\n", result);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("\n0으로 나눌수 없습니다.\n");

                goto outer;
            }
            catch(FormatException e)
            {
                Console.WriteLine("\n정수만 입력 가능합니다.\n");

                goto outer;
            }
            catch(Exception e)
            {
                Console.WriteLine("\n알수없는 오류입니다. 입력값을 확인하세요.\n");

                goto outer;
            }



            int[] arr1 = new int[4];

            try
            {
                for(int i=0; i < 5; i++)
                {
                    arr1[i] = i * i;
                }

            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("배열의 범위를 벗어났습니다.");
                Console.WriteLine(e.Message + "\n" + e.GetType() + "\n" + e.StackTrace);
            }
            finally
            {
                for(int i = 0; i < arr1.Length; i++)
                {
                    Console.WriteLine(arr1[i]);
                }
            }
        }
    }
}
