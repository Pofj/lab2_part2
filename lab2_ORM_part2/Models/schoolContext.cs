using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NodaTime;
using NodaTime.Text;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Npgsql.NodaTime;
using NpgsqlTypes;

namespace lab2_ORM_part2.Models
{
    class schoolContext : DbContext
    {
        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Teacher> Teachers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=lab_2_part_2_db;Username=postgres;Password=123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasKey(p => p.Id);
            modelBuilder.Entity<Student>().HasBaseType<Person>();
            modelBuilder.Entity<Teacher>().HasBaseType<Person>();

            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Teacher>().ToTable("Teacher");

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Student)
                .WithMany(s => s.Courses)
                .HasForeignKey(c => c.StudentId);

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Teacher)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.TeacherId);


            // Инициализация данных для студента и учителя
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "Alice", LastName = "Johnson", SeriyaPass = "3456", NomerPass = "789012", PhoneMum="123123" }
            );

            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { Id = 2, Name = "Bob", LastName = "Williams", SeriyaPass = "4567", NomerPass = "890123" }
            );

            // Инициализация данных для курса
            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, CourseName = "Math 101", StudentId = 1, TeacherId = 2 }
            );

        }

    }
}
