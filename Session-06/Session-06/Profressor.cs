using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Profressor : Person
    {
        public string? Rank { get; set; }
        public Course[]? Courses  {get;set;}

        //constructors attempt




        public void Teach(string course,DateTime datetime ) { }
        
        public void SetGrade(Guid studentID,Guid courseID,int grade ) { }

        public void GetName() { }



    }
}
