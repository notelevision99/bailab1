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

            //List<Student> listStudent = new List<Student>();
            //Console.WriteLine("Nhap tong so sinh vien N:");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("\n==========Nhap DS Sinh Vien============");
            //for(int i=0;i<n;i++)
            //{

            //    Student temp = new Student();
            //    temp.InPut();
            //    listStudent.Add(temp);
            //}

            //Console.WriteLine("============Xuat DS SINH VIEN===============");
            //foreach(Student sv in listStudent)
            //{
            //    if (sv.Faculty == "CNTT") ;
            //    sv.Show();
            //}
            //-------XUAT DSSV CACH 1
            //for(int i=0;i<n;i++)
            //{
            //    stu[i] = new Student();
            //    Console.WriteLine("Nhap Ma SV " + i + 1);
            //    stu[i].StudentID = Console.ReadLine();
            //    Console.WriteLine("Nhap Ten: ");
            //    stu[i].FullName = Console.ReadLine();
            //    Console.WriteLine("Nhap DTB: ");
            //    stu[i].AverageScore = float.Parse(Console.ReadLine());
            //    Console.WriteLine("Nhap Khoa: ");
            //    stu[i].Faculty = Console.ReadLine();
            //}
            //-------XUAT DSSV CACH 1
            //Console.WriteLine("=========Xuat DS Sinh Vien==============");
            //foreach(Student sv in stu)
            //{
            //    Console.WriteLine("MSSV: " + sv.StudentID);
            //    Console.WriteLine("Name: " + sv.FullName);
            //    Console.WriteLine("DTB: " + sv.AverageScore);
            //    Console.WriteLine("Khoa: " + sv.Faculty);
            //}
            List<Student> listStudent = LayListSVTest();
            XuatDSSV(listStudent);
            List<Student> listKQ = listStudent.Where(p => p.Faculty == "CNTT").ToList();
            if (listKQ.Count>0)
            {
                Console.WriteLine("================Danh sach sinh vien thuoc khoa CNTT=============== ");
                XuatDSSV(listKQ);
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien nao thuoc khoa CNTT! ");
            }
            List<Student> listSortStudent = listStudent.OrderBy(p => p.AverageScore).ToList();
            Console.WriteLine("============ DSSV CO DIEM TRUNG BINH TANG DAN ==========");
            XuatDSSV(listSortStudent);
            //xUAT SV CO DTB CAO NHAT VA KHOA "CNTT"
            float maxScore = listKQ.Max(p => p.AverageScore);
            List<Student> svTop = listKQ.Where(p => p.AverageScore >= maxScore).ToList();
            Console.WriteLine("====DSSV CO DTB CAO NHAT VA THUOC KHOA CNTT=====");
            XuatDSSV(svTop);
         
        }
        public static List<Student> LayListSVTest()
        {
            List<Student> listStudent = new List<Student>();
            Console.WriteLine("Nhap tong so sinh vien N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n==========Nhap DS Sinh Vien============");
            for (int i = 0; i < n; i++)
            {
                Student temp = new Student();
                temp.InPut();
                listStudent.Add(temp);
            }
            return listStudent;

        }
        public static void XuatDSSV(List<Student> listStudent)
        {
            Console.WriteLine("============Xuat DS SINH VIEN===============");
            foreach (Student sv in listStudent)
            {               
                sv.Show();
            }
        }
    }
}
