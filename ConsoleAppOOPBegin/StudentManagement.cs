using System;
using System.Collections;

namespace ConsoleAppOOPBegin
{
    namespace Students
    {
        public class StudentManagement:AbsStudent
        {
           

           /// <summary>
           /// Show all students in the array
           /// </summary>
            public void Display()
            {
                foreach(Student a in Students)
                {
                    Console.WriteLine(a);
                }
            }

            public override void Add(Student s)
            {
                //logic them moi ta viet o day
                if (s is not null)
                    this.Students.Add(s);
            }

            public override void Update(Student s)
            {
                //cach 1
                if (s is not null)
                {
                    Students.Remove(s);
                    Students.Add(s);
                }
                //cach 2: tim toi doi tuong s trong mang va thuc hien update
            }

            public override Student GetStudentById(int id)
            {
                //1 check xem id co trong mang khong
                for(int i=0; i < Students.Count; i++)
                {
                    if(((Student)Students[i]).Id == id)
                    {
                        return (Student)Students[i];
                    }
                }
                return null;
            }

            public override bool Delete(int id)
            {
                //1 Lay doi tuong sv ma co ma sinh vien = id
                Student s = GetStudentById(id);
                if(s is not null)
                {
                    Delete(s);
                    return true;
                }
                return false;
                
            }

            public override bool Delete(Student s)
            {
                if(s is not null)
                {
                    Students.Remove(s);
                    return true;

                }
                return false;
            }
        }
    }
}
