using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_School_Managment
{
    public class Student
    {
        internal object Courses;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        //The only Reason there is A question Mark, after the TypeReference, is Because of a Scholarship//
        //in the variable Fees wont be placed anything, is a Nullable Variable//
        public double? TuititionFees { get; set; }
        //One Student Can Be only, in one Course//
        public Course Course { get; set; } = new Course();
        //One student is Related to Many assigments//
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        //One student is Related to many trainers, because one Cource can
        //obtain many trainers.
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
    }
}
