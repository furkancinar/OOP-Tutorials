using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Person
    {
        private string name;
        private string tc;

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
            set
            {
                if (name != null || name != "")
                    name = value;
                else
                    Console.WriteLine("Girdiğiniz kullanıcı adınızı kontrol ediniz!!");

            }
        }

        public virtual void yazdir()
        {
            Console.WriteLine("Yazdır methodunun ilk hali");
        }


    }
}
