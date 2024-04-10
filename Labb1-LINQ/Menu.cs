using Labb1_LINQ.Data;
using Labb1_LINQ.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_LINQ
{
    internal class Menu
    {
        public static void RunMenu()
        {
            using SchoolDbContext dbContext = new SchoolDbContext();

            Console.WriteLine("    Get all teachers that teach math\n" +
                "    Get all students and their teachers\n" +
                "    Check if Programmering 1 is a subject\n" +
                "    Edit a subject from programmering 2 to OOP\n" +
                "    If student have Anas as teacher, change Anas to Reidar");

            int userOption = CursorMenu(0, 0, 4); 

            Console.Clear();

            switch (userOption)
            {
                case 0:
                    // Get all teachers who teach math
                    var teachers = (from x in dbContext.SubjectTeacherAssociation
                                    join subject in dbContext.Subject on x.SubjectId equals subject.SubjectId
                                    join teacher in dbContext.Teacher on x.TeacherId equals teacher.TeacherId
                                    where subject.SubjectName == "Math"
                                    select new
                                    {
                                        teacher.FirstName,
                                        teacher.LastName
                                    });
                    foreach (var teacher in teachers)
                    {
                        Console.WriteLine(teacher.FirstName + " " + teacher.LastName);
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 1:
                    // Get all students with their teachers
                    var result = (from course in dbContext.Course
                                  join student in dbContext.Student on course.CourseId equals student.CourseId
                                  join courseContent in dbContext.CourseContent on course.CourseId equals courseContent.CourseId
                                  join subjectTeacherAssoc in dbContext.SubjectTeacherAssociation on courseContent.SubjectByTeacherId equals subjectTeacherAssoc.SubjectTeacherId
                                  join teacher in dbContext.Teacher on subjectTeacherAssoc.TeacherId equals teacher.TeacherId
                                  orderby student.FirstName
                                  select new
                                  {
                                      studentName = student.FirstName + " " + student.LastName,
                                      teacherName = teacher.FirstName + " " + teacher.LastName,
                                  }).Distinct();

                    string tempStudentName = "";
                    foreach (var item in result)
                    {
                        if (item.studentName != tempStudentName)
                        {
                            tempStudentName = item.studentName;
                            Console.WriteLine($"Student name: {item.studentName} \t Teacher name: {item.teacherName}");
                        }
                        else
                        {
                            Console.WriteLine($"                                 Teacher name: {item.teacherName}");
                        }
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 2:
                    // Check if Subject table contains programmering1
                    bool found = (from subject in dbContext.Subject
                                  select subject.SubjectName).Contains("Programmering 1");
                    Console.WriteLine($"There is a subject named Programmering 1: {found}");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 3:
                    // Edit subject Programmering 2 to OOP
                    break;

                case 4:
                    //Update student record Teacher to Reidar if Teacher is Anas. 
                    break;
            }

        }

        public static int CursorMenu(int cursorPosition, int firstRow, int lastRow)
        {
            Console.SetCursorPosition(0, cursorPosition);
            Console.CursorVisible = false;
            Console.Write("-->");
            ConsoleKeyInfo navigator;

            do
            {
                navigator = Console.ReadKey();
                Console.SetCursorPosition(0, cursorPosition);
                Console.Write("   ");

                if (navigator.Key == ConsoleKey.UpArrow && cursorPosition > firstRow)
                {
                    cursorPosition--;
                }

                else if (navigator.Key == ConsoleKey.DownArrow && cursorPosition < lastRow)
                {
                    cursorPosition++;
                }

                Console.SetCursorPosition(0, cursorPosition);
                Console.Write("-->");
            } while (navigator.Key != ConsoleKey.Enter);

            Console.CursorVisible = true;
            return cursorPosition;
        }
    }
}
