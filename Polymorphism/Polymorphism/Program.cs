using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            //Student student2 = new Student("Furkan", "32562272212");
            //Student student3 = new Student();
            //student3.Name = "Furkan";

            //student.cs class'ı içerindeki yazdir() metodunu ihtiyaca göre değiştirebiliriz. Burada polymorphism ile method override edilmiştir.
            student1.yazdir();

            //ilk hazırlanan yazdir metodu
            Person person = new Person();
            person.yazdir();

            //teacher.cs class'ı içerisindeki yazdır metodu. Burada polymorphism ile method override edilmiştir.
            Teacher teacher = new Teacher();
            teacher.yazdir();


            //Console.WriteLine(student1.Name);
            //Console.WriteLine(student2.Name + " - " + student2.TC);
            //Console.WriteLine(student3.Name);
            Console.ReadKey();
        }
    }
}
