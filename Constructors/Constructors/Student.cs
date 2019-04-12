using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Student
    {
        public Student()
        {
            Name = "Furkan";
        }

        public Student(string name, string tc)
        {
            Name = name;
            TC = tc;
        }

        public Student(string name)
        {
            Name = name;

        }
        public string TC { get; set; }
        public string Name { get; set; }


    }
}
