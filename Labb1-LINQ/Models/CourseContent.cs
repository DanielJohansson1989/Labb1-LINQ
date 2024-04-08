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
        public virtual Course Courses { get; set; }
        public virtual SubjectTeacherAssociation SubjectByTeacher { get; set; }
        public virtual Student Students { get; set; }
    }
}
