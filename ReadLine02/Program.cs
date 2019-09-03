using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine02
{
    struct GRADE
    {
        public int kor, eng, math, total;
        public int average;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string str;
            float average;
            Console.Write("학생 수를 입력해 주세요: ");
            int nCount = int.Parse(Console.ReadLine());
            GRADE[] Grade = new GRADE[nCount];
            StreamWriter sw = new StreamWriter("test.txt");
            sw.WriteLine("학생수: {0}", nCount);
            for (int i = 0; i < nCount; i++)
            {
                str = Console.ReadLine();
                string[] DataString = str.Split(new char[] { ' ' });
                Grade[i].kor = int.Parse(DataString[0]);
                Grade[i].eng = int.Parse(DataString[1]);
                Grade[i].math = int.Parse(DataString[2]);
                Grade[i].total = Grade[i].kor + Grade[i].eng + Grade[i].math;
                average = Grade[i].total / 3.0f;
                Grade[i].average = (int)Math.Round(average);
            }

            for (int i = 0; i < nCount; i++)
            {
                sw.WriteLine("{0}, {1}, {2}, {3}, {4}", Grade[i].kor, Grade[i].eng,
                                                        Grade[i].math, Grade[i].total, Grade[i].average);
            }
            sw.Close();
        }
    }
}
