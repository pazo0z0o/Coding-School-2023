using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Student:Person
    {
        public int RegistrationNumber { get; set; }
        public Course[]? Courses { get; set; }

        //constructors attempt
        public Student() { }
        public Student(int regNumber) { RegistrationNumber = regNumber; }
        public Student(int regNumber, Course[] courses) { 
            RegistrationNumber = regNumber;
            Courses = courses;
        }
        public Student(Guid id) : base(id) { }
        public Student(Guid id, string name) : base(id, name) { }
        public Student(Guid id, string name, int age) : base(id, name, age) { }


        
        public void Attend(string course, DateTime datetime){ }

        public void WriteExam(string course, DateTime datetime){ }

}
}
