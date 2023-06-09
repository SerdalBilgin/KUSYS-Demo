﻿using System.ComponentModel.DataAnnotations;

namespace KUSYS_Demo.Models
{
    public class Student
    {

        public int StudentId { get; set; }
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<StudentCourse> StudentCourses { get; set; }
    }
}
