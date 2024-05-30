using System;
using System.Collections.Generic;
using System;
using System.Collections;
namespace ConsoleAppOOPBegin
{
    public abstract class AbsStudent
    {
        //khai bang mot mang dong (dynamic arrays) de luu list cac student
        private ArrayList lstStudent;
        public ArrayList Students { get => lstStudent; set => lstStudent = value; }

        public AbsStudent()
        {
            this.lstStudent = new ArrayList();
        }

        public AbsStudent(ArrayList lstStudent)
        {
            this.lstStudent = lstStudent;
        }

        //dinh nghia vai phuong thuc truu tuong
        /*Add new*/
        public abstract void Add(Student s);
        public abstract void Update(Student s);
        public abstract Student GetStudentById(int id);
        public abstract bool Delete(int id);
        public abstract bool Delete(Student s);

    }
}
