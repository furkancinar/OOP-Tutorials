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
                if (tc != null || tc != "")
                    tc = value;
                else
                    Console.WriteLine("Girdiğiniz TC numarasını kontrol ediniz!!");

            }
        }
        public string Name
        {
            get { return name; }
            set {
                if (name != null || name != "")
                    name = value;
                else
                    Console.WriteLine("Girdiğiniz kullanıcı adınızı kontrol ediniz!!");

            }
        }
    }
}
