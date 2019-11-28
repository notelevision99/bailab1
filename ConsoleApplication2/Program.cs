using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPerson = new List<Person>();

            Console.WriteLine("Nhap tong so doi tuong: ");
            int n = int.Parse(Console.ReadLine());
            //Khai bao doi tuong tong the
            Person person;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("1: Nhap Student; 2. Nhap Teacher");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        person = new Student();
                        person.Input();
                        listPerson.Add(person);
                        break;
                    case 2:
                        person = new Teacher();
                        person.Input();
                        listPerson.Add(person);
                        break;
                    default:
                        break;
                }
                
            }

            Console.WriteLine("============Xuat Het DS===============");

            foreach (var item in listPerson)
            {
                item.Output();
            }
            Console.ReadLine();
        }

    }
}
