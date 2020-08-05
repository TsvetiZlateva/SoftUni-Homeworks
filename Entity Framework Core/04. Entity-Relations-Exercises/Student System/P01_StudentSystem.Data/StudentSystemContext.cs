using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_StudentSystem.Data
{
    public class StudentSystemContext: DbContext
    {
        public StudentSystemContext()
        {

        }

        public StudentSystemContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<HomeworkSubmission> HomeworkSubmissions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }
     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(е => е.StudentId);

                entity.Property(e => e.Name)
                 .HasMaxLength(100)
                 .IsUnicode(true)
                 .IsRequired(true);

                entity.Property(e => e.PhoneNumber)
                .HasColumnType("char(10)")
                .IsFixedLength(true)
                .IsUnicode(false);

                entity.Property(e => e.RegisteredOn)
                .IsRequired(true);
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity.Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode(true)
                .IsRequired(true);

                entity.Property(e => e.Description)
                .IsUnicode(true);

                entity.Property(e => e.StartDate)
                .IsRequired(true);

                entity.Property(e => e.EndDate)
                .IsRequired(true);

                entity.Property(e => e.Price)
                .IsRequired(true);
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.HasKey(e => e.ResourceId);

                entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(true)
                .IsRequired(true);

                entity.Property(e => e.Url)
                .IsUnicode(false)
                .IsRequired(true);

                entity.Property(e => e.ResourceType)
                .IsRequired(true);

                entity.HasOne(r => r.Course)
                .WithMany(c => c.Resources)
                .HasForeignKey(r => r.CourseId);
            });

            modelBuilder.Entity<Homework>(entity =>
            {
                entity.HasKey(e => e.HomeworkId);

                entity.Property(e => e.Content)
                .IsUnicode(false)
                .IsRequired(true);

                entity.Property(e => e.SubmissionTime)
                .IsRequired(true);

         
            });

            modelBuilder.Entity<StudentCourse>(entity =>
            {
                entity.HasKey(sc => new { sc.StudentId, sc.CourseId });

                entity.HasOne(sc => sc.Student)
                .WithMany(s => s.StudentsCourses)
                .HasForeignKey(sc => sc.StudentId);

                entity.HasOne(sc => sc.Course)
                .WithMany(c => c.StudentsCourses)
                .HasForeignKey(sc => sc.CourseId);
            });

            modelBuilder.Entity<HomeworkSubmission>(entity =>
            {
                entity.HasKey(sc => new { sc.StudentId, sc.CourseId });

                entity.HasOne(sc => sc.Student)
                .WithMany(s => s.HomeworkSubmissions)
                .HasForeignKey(sc => sc.StudentId);

                entity.HasOne(sc => sc.Course)
                .WithMany(c => c.HomeworkSubmissions)
                .HasForeignKey(sc => sc.CourseId);
            });
        }
    }
}
