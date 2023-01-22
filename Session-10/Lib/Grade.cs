using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Grade
    {
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid StudentID { get; set; }
        public int StudentGrade { get; set; }
        //public  { get; set; } //might need to change name of variable


        public Grade() { }
        public Grade(Guid id) { ID = id; }
        public Grade(Guid id, Guid studentId)
        {
            ID = id;
            StudentID = studentId;
        }
        public Grade(Guid id, Guid studentId, Guid courseId)
        {
            ID = id;
            StudentID = studentId;
            CourseID = courseId;
            
        }
        public Grade(Guid id, Guid studentId, Guid courseId, int studentGrade)
        {
            ID = id;
            StudentID = studentId;
            CourseID = courseId;
            StudentGrade = studentGrade;
        }
    }
}
