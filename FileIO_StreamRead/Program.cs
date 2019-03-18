using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO_StreamRead
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream fs = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
            //StreamReader sr = new StreamReader(fs);
            //int value = int.Parse(sr.ReadLine());
            //float value2 = float.Parse(sr.ReadLine());
            //string str1 = sr.ReadLine();
            //sr.Close();

            //Console.WriteLine("{0} {1} {2}", value, value2, str1);

            using (StreamReader sr = new StreamReader(new FileStream("test.txt", FileMode.Open)))
            {
                int value = int.Parse(sr.ReadLine());
                float value2 = float.Parse(sr.ReadLine());
                string str1 = sr.ReadLine();

                Console.WriteLine("{0} {1} {2}", value, value2, str1);
            }


        }
    }
}
