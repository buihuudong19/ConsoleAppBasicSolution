using System;
using System.Collections;

namespace ConsoleAppOOPBegin
{
    namespace Students
    {
        public class StudentManagement
        {
            //khai bang mot mang dong (dynamic arrays) de luu list cac student
            private ArrayList lstStudent;
            public ArrayList Students { get => lstStudent; set => lstStudent = value; }

            //construct
            public StudentManagement()
            {
                this.lstStudent = new ArrayList();
            }

            public StudentManagement(ArrayList lstStudent)
            {
                this.lstStudent = lstStudent;
            }

            //add new
            public void AddStudent(Student s)
            {
                //logic them moi ta viet o day
                if(s is not null)
                    this.lstStudent.Add(s);
            }
            // return number of elements in the lstStudent
            /// <summary>
            /// This function returns a number of elements in the array list.
            /// </summary>
            /// <returns>Trả về số lượng các phần tử có trong mảng</returns>
            public int Count() => lstStudent.Count;
           /// <summary>
           /// Show all students in the array
           /// </summary>
            public void Display()
            {
                foreach(Student a in lstStudent)
                {
                    Console.WriteLine(a);
                }
            }

        }
    }
}
