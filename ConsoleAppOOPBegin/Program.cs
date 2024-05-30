using System;
using ConsoleAppOOPBegin.Students;

namespace ConsoleAppOOPBegin
{
    public class Program
    {
        static void Main(string[] args)
        {

            //1. Khởi tạo đối tượng
            Student s1 = new Student(1, "Dong", "Hai Duong",
                new DateTime(1982, 2, 19), (float)8.5);

            Student s2 = new Student();
            s2.Id = 2;
            s2.Name = "Ma Van Meo";
            s2.Address = "Quan 10";
            s2.Dob = new DateTime(2004, 04, 02);
            s2.Mark = 4.6f;

            //add s1 va s2 vao chuong trinh

            StudentManagement studentManagement = new StudentManagement();
            studentManagement.Add(s1);
            studentManagement.Add(s2);

            //Console.WriteLine(studentManagement.Count());
            studentManagement.Display();





        }
    }
}
