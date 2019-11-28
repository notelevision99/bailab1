using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap tong so sinh vien N:");
            int n = int.Parse(Console.ReadLine());
            Student[] stu = new Student[n];
            Console.WriteLine("\n==========Nhap DS Sinh Vien============");
            for(int i=0;i<n;i++)
            {
                stu[i] = new Student();
                Console.WriteLine("Nhap Ma SV: " + i + 1);
                stu[i].StudentID = Console.ReadLine();
                Console.WriteLine("Nhap Ten: ");
                stu[i].FullName = Console.ReadLine();
                Console.WriteLine("Nhap DTB: ");
                stu[i].AverageScore = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap Khoa: ");
                stu[i].Faculty = Console.ReadLine();
            }
            Console.WriteLine("=========Xuat DS Sinh Vien==============");
            foreach(Student sv in stu)
            {
                Console.WriteLine("MSSV: " + sv.StudentID);
                Console.WriteLine("Name: " + sv.FullName);
                Console.WriteLine("DTB: " + sv.AverageScore);
                Console.WriteLine("Khoa: " + sv.Faculty);
            }
        }
    }
}
