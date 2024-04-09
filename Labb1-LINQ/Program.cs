using Labb1_LINQ.Data;
using Labb1_LINQ.Models;

namespace Labb1_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // add data to database
            //using SchoolDbContext db = new SchoolDbContext();
            //db.Teacher.Add(new Teacher { FirstName = "Anas", LastName = "Qlok"});
            //db.Teacher.Add(new Teacher { FirstName = "Tobias", LastName = "Qlok"});
            //db.Teacher.Add(new Teacher { FirstName = "Reidar", LastName = "Qlok"});

            //db.Course.Add(new Course { CourseName = "SUT22" });
            //db.Course.Add(new Course { CourseName = "ITP22" }); 
            //db.Course.Add(new Course { CourseName = "SUT23" }); 
            //db.Course.Add(new Course { CourseName = "ITP23" }); 

            //db.Student.Add(new Student { FirstName = "Daniel", LastName = "Johansson", CourseId = 15 });
            //db.Student.Add(new Student { FirstName = "Petter", LastName = "Boström", CourseId = 13 });
            //db.Student.Add(new Student { FirstName = "Anton", LastName = "Hansson", CourseId = 13 });
            //db.Student.Add(new Student { FirstName = "Amanda", LastName = "Eriksson", CourseId = 14 });
            //db.Student.Add(new Student { FirstName = "Eva", LastName = "Bengtsson", CourseId = 15 });
            //db.Student.Add(new Student { FirstName = "Frida", LastName = "Andersson", CourseId = 14 });
            //db.Student.Add(new Student { FirstName = "Joakim", LastName = "Hansson", CourseId = 16 });
            //db.Student.Add(new Student { FirstName = "Johanna", LastName = "Nilsson", CourseId = 16 });

            //db.Subject.Add(new Subject { SubjectName = "Math"});
            //db.Subject.Add(new Subject { SubjectName = "OOP"});
            //db.Subject.Add(new Subject { SubjectName = "Programmering 1"});
            //db.Subject.Add(new Subject { SubjectName = "Programmering 2"});

            //db.SubjectTeacherAssociation.Add(new SubjectTeacherAssociation { SubjectId = 13, TeacherId = 10 });
            //db.SubjectTeacherAssociation.Add(new SubjectTeacherAssociation { SubjectId = 13, TeacherId = 11 }); 
            //db.SubjectTeacherAssociation.Add(new SubjectTeacherAssociation { SubjectId = 14, TeacherId = 10 }); 
            //db.SubjectTeacherAssociation.Add(new SubjectTeacherAssociation { SubjectId = 14, TeacherId = 12 }); 
            //db.SubjectTeacherAssociation.Add(new SubjectTeacherAssociation { SubjectId = 15, TeacherId = 10 }); 
            //db.SubjectTeacherAssociation.Add(new SubjectTeacherAssociation { SubjectId = 15, TeacherId = 11 }); 
            //db.SubjectTeacherAssociation.Add(new SubjectTeacherAssociation { SubjectId = 15, TeacherId = 12 }); 
            //db.SubjectTeacherAssociation.Add(new SubjectTeacherAssociation { SubjectId = 16, TeacherId = 12 }); 

            //db.CourseContent.Add(new CourseContent { CourseId = 13, SubjectByTeacherId = 3 });
            //db.CourseContent.Add(new CourseContent { CourseId = 13, SubjectByTeacherId = 7 });
            //db.CourseContent.Add(new CourseContent { CourseId = 13, SubjectByTeacherId = 10 });
            //db.CourseContent.Add(new CourseContent { CourseId = 14, SubjectByTeacherId = 4 });
            //db.CourseContent.Add(new CourseContent { CourseId = 14, SubjectByTeacherId = 6 });
            //db.CourseContent.Add(new CourseContent { CourseId = 14, SubjectByTeacherId = 8 });
            //db.CourseContent.Add(new CourseContent { CourseId = 15, SubjectByTeacherId = 3 });
            //db.CourseContent.Add(new CourseContent { CourseId = 15, SubjectByTeacherId = 7 });
            //db.CourseContent.Add(new CourseContent { CourseId = 15, SubjectByTeacherId = 5 });
            //db.CourseContent.Add(new CourseContent { CourseId = 16, SubjectByTeacherId = 9 });
            //db.CourseContent.Add(new CourseContent { CourseId = 16, SubjectByTeacherId = 4 });
            //db.CourseContent.Add(new CourseContent { CourseId = 16, SubjectByTeacherId = 10 });

            //db.SaveChanges();
            do
            {
            Menu.RunMenu();

            } while (true);
        }
    }
}
