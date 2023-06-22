using Web_courses;
using System;
using System.Linq;
namespace Web_courses
{
    public static class DbInitializer
    {
        public static void Initialize(coursesContext context)
        {
            if (context.Course.Any())
            {
                return;
            }
            var course = new Course[]{
                new Course{CourseID=1,Title="HTML",Credits=4,LaunchDate=DateTime.Parse("2023-09-01"),Ratings=2,reviews="Very Good",Instructor="Sahil", coursesCategory="Web"},
                new Course{CourseID=2,Title="CSS",Credits=2,LaunchDate=DateTime.Parse("2023-09-01"),Ratings=2,reviews="Very Good",Instructor="Sahil", coursesCategory="Web"},
                new Course{CourseID=3,Title="JavaScript",Credits=5,LaunchDate=DateTime.Parse("2023-09-01"),Ratings=2,reviews="Very Good",Instructor="Sahil", coursesCategory="Web"},
                new Course{CourseID=4,Title="Asp.NET",Credits=5,LaunchDate=DateTime.Parse("2023-09-01"),Ratings=2,reviews="Very Good",Instructor="Sahil", coursesCategory="Web"},
                new Course{CourseID=5,Title="PHP",Credits=5,LaunchDate=DateTime.Parse("2023-09-01"),Ratings=2,reviews="Very Good",Instructor="Sahil",coursesCategory="dd"},
            };
            context.Course.AddRange(course);
            context.SaveChanges();
        }
    }
}