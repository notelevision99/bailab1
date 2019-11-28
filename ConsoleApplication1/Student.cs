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
        public Student(string id,string name,float score,string falculty)
        {
            studentID = id;
            fullName = name;
            averageScore = score;
            faculty = falculty;
        }
    }
}
