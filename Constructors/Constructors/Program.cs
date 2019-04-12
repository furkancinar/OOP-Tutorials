using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student("32562272212", "Furkan");
            Student student3 = new Student("Furkan");
          

            Console.WriteLine(student1.Name);
            Console.WriteLine(student2.Name + " - " + student2.TC);
            Console.WriteLine(student3.Name);
            Console.ReadKey();
        }
    }
}
