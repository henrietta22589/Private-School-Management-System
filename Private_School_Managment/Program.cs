using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using static Private_School_Managment.Program.User_View;

namespace Private_School_Managment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creation Of the Menu//
            // We are Creating Some Constant Variables, which will Give us The opportunity, to Create
            // a better readable menu//
            MyDataBase dB = new MyDataBase();
            const int I = -40;
            const int II = -40;
            const int III = -40;
            const int IV = -40;
            const int V = -20;

            string input;
            // I Want The First Message, Which will appear to the viewer to Be the Color:Magenta
            do
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Greetings to our Private School");
                // I want this color, to not appear in the next message//
                Console.WriteLine();
                Console.ResetColor();
                // I will Change the Color, in Which the messages, will appear to the viewer//
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("In our School you Can Choose, one of the 4 Different Programming Cources");
                Console.WriteLine();
                Console.WriteLine("Your options, are can be seen just below");
                Console.WriteLine();
                // Begin-Of the Menu//
                Console.WriteLine($"{"-------------COURSES-----------",I}" +
                    $"{"-------------TRAINERS-----------",II}" +
                    $"{"-------------STUDENTS-----------",III}" +
                    $"{"-------------ASSIGNMENTS-----------",IV}");
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{"Press 1-All COURSES",I}" +
                    $"{"Press 2-TRAINERS/COURSES",II}" +
                    $"{"Press 3-STUDENTS/COURSES",III}" +
                    $"{"Press 4-ASSIGNMENTS/COURSES",IV}" +
                    $"{"Press 5-IF YOU WANT TO EXIT",V}");
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{"Press 6 IF YOU Want to See The Part Time Courses",100}");
                Console.WriteLine("If you Want to Procced, Press one of the options which is given to you");
                input = Console.ReadLine();
                //In Order The menu To be Cleared//
                Console.Clear();
                switch (input)
                {
                    case "1": User_View.Courses(dB.Courses, "All Courses Can be seen, just below"); break;
                    case "2": User_View.TrainersPerCourse(dB.Trainers, "All Trainers by Course Can be seen, just below"); break;
                    case "3": User_View.Students(dB.Students, "The Students per Course Can be seen below"); break;
                    case "4": Console.WriteLine("The Asigments per Course Can be seen below"); break;
                    default: Console.WriteLine("Wrong Input"); break;




                }
            } while (input != "5");
        }
        public class User_View
        {
            public static void Courses(List<Course> Courses, string message)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{"Title",-30}{"Stream",-20}{"Type",-20}{"StartDate",-20}{"EndDate",-20}");
                foreach (var Course in Courses)
                {
                    Course.Print();
                }

            }

            public static void Trainers(List<Trainer> trainers, string message)
            {

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{"FirstName",-30}{"LastName",-20}");
                foreach (var Course in Courses)
                {
                    Course.Print();
                    foreach (var tr in Course.Trainer)
                    {
                        Console.WriteLine($"{Course.FirstName,-30}{Course.LastName,-20}");
                    }
                }

            }

            public static void Students(List<Student> students, string message)
            {
                
            }

            internal static void TrainersPerCourse(List<Trainer> trainers, string message)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{"Title",-30}{"Stream",-20}{"Type",-20}{"StartDate",-20}{"EndDate",-20}");
            }
            public void Print_Title()
            {
                Console.WriteLine($"{Title,-18}");
            }
        }
    }
































