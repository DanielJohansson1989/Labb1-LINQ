using Labb1_LINQ.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_LINQ.Data
{
    internal class SchoolDbContext : DbContext
    {
        public DbSet<Course> Course {  get; set; }
        public DbSet<Student> Student {  get; set; }
        public DbSet<Subject> Subject {  get; set; }
        public DbSet<Teacher> Teacher {  get; set; }

        public DbSet<CourseContent> CourseContent { get; set; }
        public DbSet<SubjectTeacherAssociation> SubjectTeacherAssociation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Data Source = LAPTOP-4AAOB4IN; Initial Catalog=Labb1-LINQDB; Integrated Security = True; TrustServerCertificate=Yes;");
        }
    }
}
