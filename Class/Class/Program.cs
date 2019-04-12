using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();
            student.Name = "Furkan";
            student.TC = "32562272212";

            Teacher teacher = new Teacher();
            teacher.Name = "Ahmet";
            teacher.TC = "32562272212";
            teacher.Branch = "Bilgisayar";

            Console.WriteLine(student.Name + " - " + student.TC);
            Console.WriteLine();
            Console.WriteLine(teacher.Name + " - " + teacher.TC + " - " + teacher.Branch);
            Console.ReadKey();
        }
    }
}
