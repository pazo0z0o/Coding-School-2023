using Session_10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib_Session_10
{
    public class University //: Institute
    {
        public Guid ID { get; set; }
        public Student[]? Students { get; set; }
        public Course[]? Courses { get; set; }
        public Grade[]? Grades { get; set; }
        public Schedule[]? ScheduleCourse { get; set; }
        //constructors attempt

        public University() { ID = Guid.NewGuid(); }
       
    }
}
