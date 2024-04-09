using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_LINQ.Models
{
    internal class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        [MaxLength(50)]
        public string CourseName { get; set; }
        public ICollection<CourseContent> CourseContent { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
