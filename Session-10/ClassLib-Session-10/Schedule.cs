﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib_Session_10
{
    public class Schedule
    {
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }
        public DateTime Calendar { get; set; }
        public Guid UniversityID { get; set; }

        public Schedule() 
        { 
            ID = Guid.NewGuid();
            CourseID = Guid.NewGuid();
            ProfessorID= Guid.NewGuid();
            Calendar = DateTime.Now;
        }
       
        
       

    }
}
