using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Student
    {
        private string name;
        private string tc;

        public Student()
        {
            Name = "Furkan";
        }

        public Student(string name, string tc)
        {
            this.Name = name;
            this.TC = tc;
        }

        public Student(string name)
        {
            Name = name;
        }


        public string TC
        {
            get { return tc; }
            set
            {
                if (value.Length > 10 && value.Length < 12)
                    tc = value;
                else
                    tc = "Girdiğiniz TC numarası 11 haneli olmak zorundadır!";

            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value != null || value != "")
                    name = value;
                else
                    tc = "Girdiğiniz kullanıcı adınızı kontrol ediniz!!";

            }
        }
    }
}
