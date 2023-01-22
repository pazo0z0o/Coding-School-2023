using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Student:Person
    {
        public int RegistrationNumber { get; set; }
        public List<Course>? Courses { get; set; }
        public Guid UniversityID { get; set; } //might need to change name of variable
        //constructors attempt
        public Student() { }
        
        public Student(Guid id) : base(id) { }

       


        /* public void Attend(string course, DateTime datetime){ }
         public void WriteExam(string course, DateTime datetime){ }*/

    }
}
