﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeService.Models
{
    public class Enrollment
    {        
        public int StudentId { get; set; }
        public Student Student { get; set; }
        
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public DateTime EnrollmentDate { get; set; }
    }
}