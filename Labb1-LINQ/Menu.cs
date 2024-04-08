using Labb1_LINQ.Data;
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

            Console.WriteLine("    Print menu");

            int userOption = CursorMenu(0, 0, 1); //Change argument to correct rows 

            Console.Clear();

            switch (userOption)
            {
                case 0:
                    // Get all teachers who teach math
                    break;

                case 1:
                    // Get all students with their teachers
                    break;

                case 2:
                    // Check if Subject table contains programmering1
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
