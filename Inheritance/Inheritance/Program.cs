using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student("Furkan", "32562272212");
            Student student3 = new Student();
            student3.Name = "Furkan";


            Console.WriteLine(student1.Name);
            Console.WriteLine(student2.Name + " - " + student2.TC);
            Console.WriteLine(student3.Name);
            Console.ReadKey();
        }
    }
}
