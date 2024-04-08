using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_LINQ.Models
{
    internal class SubjectTeacherAssociation
    {
        [Key]
        public int SubjectTeacherId { get; set; }
        public virtual Subject Subjects { get; set; }
        public virtual Teacher Teachers { get; set; }
    }
}
