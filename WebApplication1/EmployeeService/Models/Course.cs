﻿namespace EmployeeService.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Enrollment> Enrollments { get; set; }
    }
}