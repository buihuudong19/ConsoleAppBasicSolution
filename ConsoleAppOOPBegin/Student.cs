using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleAppOOPBegin
{
    public class Student
    {
        //1. có gì? ---> thuộc tính/properties/data/fields (what)
        /*1.1 - fields */
        private int id;
        private string name;
        /*1.2 - properties*/
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get; set;}
        public DateTime Dob { get; set; }
        public float Mark { get; set;}

        //2. Constructors (no parammeter) 
        public Student()
        {
        }
        public Student(int id, string name, string address, 
            DateTime dob, float mark)
        {
            Id = id;
            Name = name;
            Address = address;
            Dob = dob;
            Mark = mark;
        }

        //3. Regular function (methods/action/behaviors) --> how
        /*
        public void Print()
        {
            string result = $"Id = {id}, Name = {Name}, Add = {Address}" +
                $"Dob = {Dob} and Mark = {Mark}";

            Console.WriteLine(result);
        }
        */
        public override string ToString()
        {
            string result = $"Id = {id}, Name = {Name}, Add = {Address}" +
                $"Dob = {Dob} and Mark = {Mark}";
            return result;
        }
        //manual function getAge
        public int GetAge()
        {
            //logic
            int age = 0;
            DateTime today = DateTime.Now;
            age = today.Year - Dob.Year;
            //Chưa đến ngày sinh nhật thì trừ 1 tuổi
            if (Dob.Date > today.AddYears(-age))
                age--;
            
            return age;
        }

    }
}
