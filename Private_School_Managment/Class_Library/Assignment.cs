using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_School_Managment
{
    public class Assignment
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Submission { get; set; }
        public float? OralMark { get; set; }
        public float? Total { get; set; }
        // Each Assignment is Related to Multiple Students//
        public List<Student> Students { get; set; } = new List<Student>();
        //Each Assignment is Related to one Trainer//
        public Trainer Trainer { get; set; } = new Trainer();
        //Each Assignment is Related to one Course//
        public Course Course { get; set; } = new Course();
        public object Trainers { get; internal set; }
        public object Courses { get; internal set; }
    }
}
