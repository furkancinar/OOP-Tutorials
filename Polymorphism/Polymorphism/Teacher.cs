using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Teacher : Person
    {
        private string branch;
        private string enrolmentName;

        public Teacher()
        {
            Name = "Öğretmen Adı";
        }

        public string Branch
        {
            get { return branch; }
            set
            {
                if (branch != null || branch != "")
                    branch = value;
                else
                    Console.WriteLine("Girdiğiniz değeri kontrol ediniz!!");

            }
        }

        public string EnrolmentName
        {
            get { return enrolmentName; }
            set
            {
                if (enrolmentName != null || enrolmentName != "")
                    enrolmentName = value;
                else
                    Console.WriteLine("Girdiğiniz değeri kontrol ediniz!!");

            }
        }
    }
}
