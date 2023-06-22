using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web_courses
{
    public class Course
    {
        public int CourseID { get; set; }
        [Required]
        [StringLength(32, MinimumLength = 4)]
        [RegularExpression("^[A-Z][A-Za-z ]*$")]
        public string Title { get; set; }


        [Required(ErrorMessage = "Don't Empty the fields")]
        [StringLength(1, MinimumLength = 1)]
        [RegularExpression("[1-5]+")]
        public int Credits { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime LaunchDate { get; set; }


        [Required]
        [StringLength(32, MinimumLength = 4)]
        [RegularExpression("[A-Za-z]+")]
        public string Instructor { get; set; }


        [Required]
        [StringLength(1, MinimumLength = 1)]
        [RegularExpression("^[A-Z][A-Za-z ]*$")]
        public string coursesCategory { get; set; }


        [Required]
        [StringLength(1, MinimumLength = 1)]
        [RegularExpression("[1-5]")]
        public int Ratings { get; set; }


        [Required]
        [StringLength(32, MinimumLength = 4)]
        [RegularExpression("[A-Za-z]+")]
        public string reviews { get; set; }





    }
}