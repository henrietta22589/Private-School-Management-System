using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_School_Managment
{
    public class Course
    {
        //Creation Of proPerties
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        //Each Course is Related With multiple Students//
        public List<Student> Students { get; set; } = new List<Student>();
        //Each Course Can be related, with multiple Trainers//
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        // Each Cource is Related With many Assigments//
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

        internal void Add(Course c_8)
        {
            throw new NotImplementedException();
        }
        // Creating A Method, which will provide me the opportuniy to display my Data, more properly 
        //to the user//
        public void Print()
        {
            Console.WriteLine($"{Title,-30}{Stream,-20}{Type,-20}{StartDate,-20}{EndDate,-20}");
        }
    }
}
