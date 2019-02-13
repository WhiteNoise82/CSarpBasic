using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExClass
{
    class Cat : Mammal
    {

        public Cat(string name, DateTime birthday, string color, Gender gender)
            :base(name, birthday, color, gender)
        {
        }

        public override string MakeSound()
        {
            return "야옹";
        }

        public string Scratch()
        {
            return "할큄";
        }

    }
}
