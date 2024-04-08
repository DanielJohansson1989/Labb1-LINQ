using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_LINQ.Models
{
    internal class CourseContent
    {
        [Key]
        public int CourseContentId { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<SubjectTeacherAssociation> SubjectTeachers { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
