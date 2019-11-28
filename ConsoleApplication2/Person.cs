using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    abstract class Person 
    {
        public string FullName { get; set; }
        public string Faculty { get; set; }

        public Person()
        {

        }
        public Person(string name, string faculty )
        {
            FullName = name;
            Faculty = faculty;
        }

        public virtual void Input()
        {
            Console.WriteLine("Nhap Ten: ");
            FullName = Console.ReadLine();
            Console.WriteLine("Nhap Khoa: ");
            Faculty = Console.ReadLine();
        }
        public virtual void Output()
        {
            Console.WriteLine("Name: " + FullName);
            Console.WriteLine("Faculty: " + Faculty);
        }
    }
}
