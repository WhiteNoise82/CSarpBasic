using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine01
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;
            int StudentNumber = 0;
            string Marks;
            string[] StudentMark;

            do
            {
                Console.Write("학생 수를 입력하세요: ");
                StudentNumber = int.Parse(Console.ReadLine());

                if (StudentNumber <= 0)
                {
                    Console.WriteLine("학생 수를 잘못 입력하였습니다.\n다시 입력하여 주세요.");
                }
                else
                {
                    break;
                }
            } while (true);

            //StudentMark = new string[StudentNumber];

            for (int i = 0; i < StudentNumber; i++)
            {
                Console.WriteLine("{0}번 학생의 점수를 입력해 주세요.", i + 1);
                Marks = Console.ReadLine();
                StudentMark = Marks.Split(new char[] { ' ' });
                using (StreamWriter sw = new StreamWriter(new FileStream("StudentMarks.txt", FileMode.Append, FileAccess.Write)))
                {
                    sw.WriteLine("국어: {0}, 영어: {1}, 수학: {2}", StudentMark[0], StudentMark[1], StudentMark[2]);
                    
                }
            }

        }
    }
}
