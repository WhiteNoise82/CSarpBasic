using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO_StreamWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 12;
            float value2 = 3.14f;
            string str1 = "Hello World!";

            //FileStream fs = new FileStream("test.txt", FileMode.Create);
            //FileStream fs = new FileStream("test.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter("test.txt");
            
            sw.WriteLine(value);
            sw.WriteLine(value2);
            sw.WriteLine(str1);
            sw.Close();

            //using(StreamWriter sw=new StreamWriter(new FileStream("test1.txt", FileMode.Create)))
            //{
            //    sw.WriteLine(value);
            //    sw.WriteLine(value2);
            //    sw.WriteLine(str1);
            //}

        }
    }
}
