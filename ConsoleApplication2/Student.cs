using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Student : Person
    {       
        public string StudentID { get; set; }
        public float AverageScore { get; set; }

        public Student()
        {

        }

        public Student(string id, string name, float score, string falculty) : base(name, falculty)
        {
            StudentID = id;
            AverageScore = score;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap Ma SV ");
            StudentID = Console.ReadLine();
            Console.WriteLine("Nhap DTB: ");
            AverageScore = float.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("MSSV: " + this.StudentID);
            Console.WriteLine("DTB: " + this.AverageScore);
        }
    }
}

