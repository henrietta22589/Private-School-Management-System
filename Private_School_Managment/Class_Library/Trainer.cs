using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_School_Managment
{
    public class Trainer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // One Trainer can be Related to many Courses//
        public List<Course> Courses { get; set; } = new List<Course>();
        //One Trainer is obligated to examine multiple Assigments//
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        // One Trainer is Related to multiple students//
        public List<Student> Students { get; set; } = new List<Student>();

        internal void Add(Trainer t5)
        {
            throw new NotImplementedException();
        }
        public void Print_1()
        {
            Console.WriteLine($"{FirstName,-20}{LastName,-20}");
        }

    }
}
