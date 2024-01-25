﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Visit : BaseEntity
    {
        public int VisitID { get; set; }
        public DateTime VisitDate { get; set; }
        public int Duration { get; set; }

        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }// 
        
        
        public int PatientID { get; set; }
        public Patient Patient { get; set; }

        //relations below

        

        
    }
}
