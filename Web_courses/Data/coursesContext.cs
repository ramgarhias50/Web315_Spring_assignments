using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web_courses;

public class coursesContext : DbContext
{
    public coursesContext(DbContextOptions<coursesContext> options)
        : base(options)
    {
    }

    public DbSet<Course> Courses { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder) { modelBuilder.Entity<Course>().ToTable("Course"); }

    public DbSet<Web_courses.Course> Course { get; set; }

}
