using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Teacher : Person
    {
        public string TeacherID { get; set; }
        public string TeacherAddress { get; set; }

        public Teacher()
        {

        }
        public Teacher(string teacherID, string teacherName, string teacherAddress, string falcuty) : base(teacherName, falcuty)
        {
            TeacherID = teacherID;
            TeacherAddress = teacherAddress;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap teacher id: ");
            TeacherID = Console.ReadLine();
            Console.WriteLine("Nhap dia chi giao vien: ");
            TeacherAddress = Console.ReadLine();
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("ID Giao Vien : " + this.TeacherID);
            Console.WriteLine("Dia Chi: " + this.TeacherAddress);

        }
    }
}
