using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web_courses;

    public class coursesContext : DbContext
    {
        public coursesContext (DbContextOptions<coursesContext> options)
            : base(options)
        {
        }

        public DbSet<Web_courses.Course> Course { get; set; }
    }
