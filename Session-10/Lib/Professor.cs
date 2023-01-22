using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
        public class Professor : Person
        {
            public string? Rank { get; set; }
            public Course[]? Courses { get; set; }

            //constructors attempt
            public Professor() { }
            
            //public Professor(Guid id) : base(id) { }
            


            //methods
            /*public void Teach(string course, DateTime datetime) { }
            public void SetGrade(Guid studentID, Guid courseID, int grade) { }
            public void GetName() { }*/



        }
    }


