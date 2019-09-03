using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bWriter01
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (BinaryWriter bw = new BinaryWriter(new FileStream("test.dat", FileMode.Create)))
            using (BinaryWriter bw = new BinaryWriter(File.Create("test.dat")))
            {
                bw.Write(12);
                bw.Write(3.14f);
                bw.Write("Hello World!");
            }
        }
    }
}
