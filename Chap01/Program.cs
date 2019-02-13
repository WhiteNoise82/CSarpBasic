using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 255;       // byte     : 1바이트(8비트)  0 ~ 255(2의 8승-1)
            sbyte b = 127;      // sbyte    : 1바이트(8비트)  -128 ~ 127(2의 7승-1)
            short c = 32767;    // short    : 2바이트(16비트) -32768 ~ 32767(2의 15승-1)
            ushort d = 65535;   // ushort   : 2바이트(16비트) 0 ~ 65535(2의 16승-1)
            int e = 32767;      // int      : 4바이트(32비트) 2의 31승-1 ~ 2의 31승-1
            uint f = 65535;     // uint     : 4바이트(32비트) 0 ~ 2의 32승-1
            long g = 32767;     // long     : 8바이트(64비트) -2의 63승 ~ 2의 63승-1
            ulong h = 65535;    // ulong    : 8바이트(64비트) 0 ~ 2의 64승-1

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
        }
    }
}
