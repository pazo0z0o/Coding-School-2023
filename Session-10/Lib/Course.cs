using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Course
    {
        public Guid ID { get; set; }
        public string? Code { get; set; }
        public string?  Subject { get; set; }


        public Course() { }
        public Course(Guid ID) { }
        public Course(Guid ID, string Code) { }
        public Course (Guid ID, string Code, string Subject) { }

    }
}
