using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "0123456789";

            char[] str = new char[str1.Length];

            Console.WriteLine(str1);

            for (int i = 0; i < str1.Length; i++)
            {
                str[i] = str1[i];
            }

            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
            }

            Console.WriteLine();
            for (int j = 1; j < str.Length; j++)
            {
                for (int i = 0; i < str.Length - j; i++)
                {
                    char temp;

                    temp = str[i + 1];
                    str[i + 1] = str[i];
                    str[i] = temp;
                }
            }

            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
            }

            Console.WriteLine();
        }
    }
}
