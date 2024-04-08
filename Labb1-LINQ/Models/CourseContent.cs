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
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int SubjectByTeacherId {  get; set; }
        public SubjectTeacherAssociation SubjectByTeacher { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
