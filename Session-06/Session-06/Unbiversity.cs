using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Unbiversity : Institute
    {
        public Student[]? Students { get; set; }
        public Course[]? Courses { get; set; }
        public Grade[]? Grades { get; set; }
        public Schedule[]? ScheduleCourse { get; set; }
        //constructors attempt

        public Unbiversity() { }
        public Unbiversity(Student[] students ) { Students = students; }
        public Unbiversity(Student[] students, Course[] courses) { Students = students;
            Courses = courses;
        }
        public Unbiversity(Student[] students, Course[] courses, Grade[] grades) 
        {   Students = students;
            Courses = courses;
            Grades = grades;
        }
        public Unbiversity(Student[] students, Course[] courses,Grade[] grades, Schedule[] schedule )
        {
            Students = students;
            Courses = courses;
            Grades = grades;
            ScheduleCourse = schedule;
        }


               










        public void GetStudents() { }
        public void GetCourses() { }
        public void GetGrades() { }
        public void SetSchedule (Guid courseID,Guid proffesorID, DateTime datetime) { }
    }
}
