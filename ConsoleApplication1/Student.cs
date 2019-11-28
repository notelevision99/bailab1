using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student
    {
        
        private string studentID;
        private string fullName;
        private float averageScore;
        private string faculty;
        public string StudentID { get; set; }
        public string FullName { get; set; }
        public float AverageScore { get; set; }
        public string Faculty { get; set; }
        public Student()
        {

        }
        public Student(string id, string name, float score, string falculty)
        {
            studentID = id;
            fullName = name;
            averageScore = score;
            faculty = falculty;
        }
        public Student(string id,string name)
        {
            studentID = id;
            fullName = name;
        }
        
        public void InPut()
        {
            
            Console.WriteLine("Nhap Ma SV ");
            StudentID = Console.ReadLine();
            Console.WriteLine("Nhap Ten: ");
            FullName = Console.ReadLine();
            Console.WriteLine("Nhap DTB: ");
            AverageScore = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Khoa: ");
            Faculty = Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine("MSSV: " + this.StudentID);
            Console.WriteLine("Name: " + this.FullName);
            Console.WriteLine("DTB: " + this.AverageScore);
            Console.Write("Khoa: " + this.Faculty +"\n");
        }
        
        
    }
}
