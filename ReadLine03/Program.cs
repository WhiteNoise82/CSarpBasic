﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine03
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str;
            //Console.Write("파일명을 입력해 주세요: ");
            //string fileName = Console.ReadLine();
            //StreamReader sr = new StreamReader(fileName);
            //str = sr.ReadLine();
            //string[] strData1 = str.Split(new char[] { ':' });
            //int nCount = int.Parse(strData1[1]);
            //Console.WriteLine("-----------------------------------------");
            //for (int i = 0; i < nCount; i++)
            //{
            //    str = sr.ReadLine();
            //    string[] strData2 = str.Split(new char[] { ',' });
            //    Console.WriteLine("{0} {1} {2} {3} {4}", strData2[0], strData2[1], strData2[2], strData2[3], strData2[4]);
            //}
            //Console.WriteLine("-----------------------------------------");
            //sr.Close();

            string str = null;
            StreamReader sr = new StreamReader("test.txt");
            for (int i = 0; i < 5; i++)
            {
                str = sr.ReadLine();
                Console.WriteLine(str);
            }
        }
    }
}
