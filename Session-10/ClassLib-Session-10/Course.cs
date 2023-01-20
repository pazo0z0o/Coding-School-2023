using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib_Session_10
{
    public class Course
    {
        public Guid ID { get; set; }
        public string? Code { get; set; }
        public string?  Subject { get; set; }
        public Guid UniversID { get; set; }
        public Course() { ID = Guid.NewGuid(); }
        // public Course(Guid id, string code) {ID=id; Code = code; }

    }
}
