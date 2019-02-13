using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExClass
{
    public enum Gender { male, female }

    class Mammal
    {
        public string Name;
        private DateTime _Birthday;
        private string _Color;
        private Gender _Gender;
        public string Discreption;

        public Mammal(string name, DateTime birthday, string color, Gender gender)
        {
            this.Name = name;
            this.Birthday = birthday;
            this.Color = color;
            this.Gender = gender;
        }

        public DateTime Birthday
        {
            get { return _Birthday; }
            set
            {
                _Birthday = value;
            }
        }

        public string Color
        {
            get { return _Color; }
            set
            {
                _Color = value;
            }
        }

        public Gender Gender
        {
            get { return _Gender; }
            set
            {
                _Gender = value;
            }
        }

        public int Age
        {
            get { return DateTime.Now.Year - _Birthday.Year; }
        }

        public virtual string MakeSound()
        {
            return "";
        }

       

    }
}
