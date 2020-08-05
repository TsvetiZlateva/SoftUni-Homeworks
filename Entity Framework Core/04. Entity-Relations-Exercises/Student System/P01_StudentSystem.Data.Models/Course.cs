using System;
using System.Collections.Generic;
using System.Text;

namespace P01_StudentSystem.Data.Models
{
    public class Course
    {
        public Course()
        {
            this.StudentsCourses = new HashSet<StudentCourse>();
            this.HomeworkSubmissions = new HashSet<HomeworkSubmission>();
            this.Resources = new HashSet<Resource>();
        }
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public ICollection<StudentCourse> StudentsCourses { get; set; }
        public ICollection<HomeworkSubmission> HomeworkSubmissions { get; set; }
        public ICollection<Resource> Resources { get; set; }


    }
}
