using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Student : Person
    {

        private string sectionName;
        private string studentNumber;

        public Student()
        {
            Name = "Öğrenci Adı";
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



        public string SectionName
        {
            get { return sectionName; }
            set
            {
                if (sectionName != null || sectionName != "")
                    sectionName = value;
                else
                    Console.WriteLine("Girdiğiniz değeri kontrol ediniz!!");

            }
        }

        public string StudentNumber
        {
            get { return studentNumber; }
            set
            {
                if (studentNumber != null || studentNumber != "")
                    studentNumber = value;
                else
                    Console.WriteLine("Girdiğiniz değeri kontrol ediniz!!");

            }
        }

        public override void yazdir()
        {
            Console.WriteLine("yazdir metodu içerisindeki değerler değiştirildi.(Polymorphism)");
        }


    }
}
