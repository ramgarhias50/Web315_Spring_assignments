﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Web_courses.Migrations
{
    [DbContext(typeof(coursesContext))]
    [Migration("20230622172855_reviews")]
    partial class reviews
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Web_courses.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Credits")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Instructor")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LaunchDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("coursesCategory")
                        .HasColumnType("TEXT");

                    b.Property<int>("ratings")
                        .HasColumnType("INTEGER");

                    b.Property<string>("reviews")
                        .HasColumnType("TEXT");

                    b.HasKey("CourseID");

                    b.ToTable("Course");
                });
#pragma warning restore 612, 618
        }
    }
}