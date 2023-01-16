using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Professor : Person
    {
        public string? Rank { get; set; }
        public Course[]? Courses  {get;set;}

        //constructors attempt
        public Professor() { }
        public Professor(string rank) { Rank = rank; }
        public Professor(string rank, Course[] courses) {
            Rank = rank; 
            Courses = courses;
        }
        public Professor(Guid id):base(id) { }
        public Professor(Guid id,string name) : base(id,name) { }
        public Professor(Guid id, string name,int age) : base(id, name,age) { }


        //methods
        public void Teach(string course,DateTime datetime ) { }
        public void SetGrade(Guid studentID,Guid courseID,int grade ) { }
        public void GetName() { }



    }
}
