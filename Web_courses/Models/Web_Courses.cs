using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web_courses
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public DateTime LaunchDate { get; set; }
        [DataType(DataType.Date)]
        public string Instructor { get; set; }
        public string coursesCategory { get; set; }
        public int ratings {get; set;}
        public string reviews {get; set;}



    }
}