using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib_Session_10
{
    public class Grade
    {
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid StudentID { get; set; }
        public int StudentGrade { get; set; }




        public Grade() { ID = Guid.NewGuid(); }
        
    }
}
