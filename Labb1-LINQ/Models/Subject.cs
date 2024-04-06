using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_LINQ.Models
{
    internal class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        [Required]
        [MaxLength(50)]
        public string SubjectName { get; set; }
        public virtual ICollection<Course> Courses { get; set; } //varje ämne finns i flera utbildningar
        public virtual ICollection<Teacher> Teachers { get; set; } // det finns flera lärare i samma ämne
    }
}
