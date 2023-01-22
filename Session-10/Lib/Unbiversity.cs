using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class University : Institute
    {
        public List<Student>? Students  { get; set; }
        public List<Course>? Courses { get; set; }
        public List<Grade>? Grades { get; set; }
        public List<Schedule>? ScheduledCourse { get; set; }
        //constructors attempt

        public University() { }
        
       

        
        //public University(Guid id,string name) : base(id,name){ }
       

        /*public void GetStudents() { }
        public void GetCourses() { }
        public void GetGrades() { }
        public void SetSchedule (Guid courseID,Guid proffesorID, DateTime datetime) { }*/
    }
}
