using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProg2
{
    class Program
    {
        static void Change<T>(ref T firstNum, ref T SecondNum)
        {
            T temp;
            temp = firstNum;
            firstNum = SecondNum;
            SecondNum = temp;
        }

        public static void TestChange()
        {
            #region 오브젝트 타입 사용
            Console.WriteLine("첫번째 수를 입력하세요.");
            object a = Console.ReadLine();

            Console.WriteLine("두번째 수를 입력하세요.");
            object b = Console.ReadLine();

            Console.WriteLine("첫번째 수: {0}, 두번째 수: {1}", a, b);

            Console.WriteLine("\n--- 두 수의 위치를 바꿉니다. ---\n");
            Change(ref a, ref b);
            Console.WriteLine("첫번째 수: {0}, 두번째 수: {1}", a, b);
            #endregion

            Console.WriteLine("\n\n-----------------------------------\n\n");

            #region 제네릭 사용
            Console.WriteLine("첫번째 수를 입력하세요.");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("두번째 수를 입력하세요.");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("첫번째 수: {0}, 두번째 수: {1}", c, d);

            Console.WriteLine("\n--- 두 수의 위치를 바꿉니다. ---\n");
            Change<int>(ref c, ref d);
            Console.WriteLine("첫번째 수: {0}, 두번째 수: {1}", c, d);
            #endregion
        }

        static void Main(string[] args)
        {
            TestChange();
        }
    }
}
