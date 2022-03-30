using System;
using System.Collections.Generic;

namespace Private_School_Managment
{
    //Creation Of Dummy Data//
    // For The Creation Of Data, we will Need to ConstruCt A Class//
    public class MyDataBase
    {
        private Trainer t_1;
        private Trainer t_2;
        private Trainer t_3;
        private Trainer t_4;
        private Trainer t_5;

        //Inside this part of the Class, i will conclute all the Lists and The Nested Classes, which
        //Have been Used, in this part all of them will be initialized//
        public List<Student> Students { get; set; } = new List<Student>();
        public Trainer Trainer { get; set; } = new Trainer();
        public Course Course { get; set; } = new Course();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        public List<Course> Courses { get; set; } = new List<Course>();
        

        // For the Creation Of Data Base, We will Use A constructor//
        public MyDataBase(Assignment As_1, Assignment As_2, Assignment As_3, Assignment As_4, Assignment As_5, Trainer T1, Trainer T2, Trainer T3, Trainer T4, Trainer T5,
            Student S_1, Student S_2, Student S_3, Student S_4, Student S_5, Course C_1, Course C_2, Course C_3, Course C_4, Course C_5, Course C_6, Course C_7, Course C_8
            )
        {
            #region MyData_For_The_Courses
            //Creation Of Synthetic Data, Creation Of the Object,which is related to the Class-Courses//
            Course c_1 = new Course()
            {
                Title = "C#",
                Stream = "CB8",
                Type = "Full_Course",
                StartDate = new DateTime(2021, 1, 1),
                EndDate=new DateTime(2021,4,1),
            };

            //Each Course is Related to a List Of Students//
            Student s_1 = S_1;
            Student s_2 = S_2;
            Student s_3 = S_3;
            Student s_4 = S_4;
            Student s_5 = S_5;
            Assignment as_1 = As_1;
            Assignment as_2 = As_2;
            Assignment as_3 = As_3;
            Assignment as_4 = As_4;
            Assignment as_5 = As_5;
            Course /*c_1*/ = C_1;
            Course c_2 = C_2;
            Course c_3 = C_3;
            Course c_4 = C_4;
            Course c_5 = C_5;
            Course c_6 = C_6;
            Course c_7 = C_7;
            Course c_8 = C_8;
            c_1.Students = new List<Student>() { s_1, s_2, s_3, s_4, s_5 };
            //Each Course is Related to a List of Assignments
            c_1.Assignments = new List<Assignment>() { as_1, as_2, as_3, as_4, as_5 };
            //Each Course is Related to Multiple Trainers//
            Trainer t1 = T1;
            Trainer t2 = T2;
            Trainer t3 = T3;
            Trainer t4 = T4;
            Trainer t5 = T5;
            c_1.Trainers = new List<Trainer>() { t1, t2, t3, t4, t5 };
            // At this point We will start Creating the Relation Of the Student to the Course
            s_1.Course.Add(c_1);
            s_2.Course.Add(c_1);
            s_3.Course.Add(c_1);
            s_4.Course.Add(c_1);
            s_5.Course.Add(c_1);
            //Now We Will Start Creating The relation Between The Assignments with the Courses
            as_1.Course.Add(c_1);
            as_2.Course.Add(c_1);
            as_3.Course.Add(c_1);
            as_4.Course.Add(c_1);
            as_5.Course.Add(c_1);
            //At last We Will Create The relation Between The Trainers with The Assignments//
            t1.Courses.Add(c_1);
            t2.Courses.Add(c_1);
            t3.Courses.Add(c_1);
            t4.Courses.Add(c_1);
            t5.Courses.Add(c_1);
            _ = new Course()
            {
                Title = "C#",
                Stream = "CB8",
                Type = "Part_Course",
                StartDate = new DateTime(2021, 1, 1),
                EndDate = new DateTime(2021, 7, 1),
            };
            //Each Course is Related to a List Of Students//
            c_2.Students = new List<Student>() { s_1, s_2, s_3, s_4, s_5 };
            //Each Course is Related to a List of Assignments
            c_2.Assignments = new List<Assignment>() { as_1, as_2, as_3, as_4, as_5 };
            //Each Course is Related to Multiple Trainers//
            c_2.Trainers = new List<Trainer>() { t1, t2 , t3, t4,t5 };
            // At this point We will start Creating the Relation Of the Student to the Course
            s_1.Course.Add(c_2);
            s_2.Course.Add(c_2);
            s_3.Course.Add(c_2);
            s_4.Course.Add(c_2);
            s_5.Course.Add(c_2);
            //Now We Will Start Creating The relation Between The Assignments with the Courses
            as_1.Course.Add(c_2);
            as_2.Course.Add(c_2);
            as_3.Course.Add(c_2);
            as_4.Course.Add(c_2);
            as_5.Course.Add(c_2);
            //At last We Will Create The relation Between The Trainers with The Assignments//
            t1.Courses.Add(c_2);
            t2.Courses.Add(c_2);
            t3.Courses.Add(c_2);
            t4.Courses.Add(c_2);
            t5.Courses.Add(c_2);
            _ = new Course()
            {
                Title = "JavaScript",
                Stream = "CB9",
                Type = "Full_Course",
                StartDate = new DateTime(2021, 1, 1),
                EndDate = new DateTime(2021, 4, 1),
            };
            //Each Course is Related to a List Of Students//
            c_3.Students = new List<Student>() { s_1, s_2, s_3, s_4, s_5 };
            //Each Course is Related to a List of Assignments
            c_3.Assignments = new List<Assignment>() { as_1, as_2, as_3, as_4, as_5 };
            //Each Course is Related to Multiple Trainers//
            c_3.Trainers = new List<Trainer>() { t1, t2 , t3, t4, t4 };
            // At this point We will start Creating the Relation Of the Student to the Course
            s_1.Course.Add(c_3);
            s_2.Course.Add(c_3);
            s_3.Course.Add(c_3);
            s_4.Course.Add(c_3);
            s_5.Course.Add(c_3);
            //Now We Will Start Creating The relation Between The Assignments with the Courses
            as_1.Course.Add(c_3);
            as_2.Course.Add(c_3);
            as_3.Course.Add(c_3);
            as_4.Course.Add(c_3);
            as_5.Course.Add(c_3);
            //At last We Will Create The relation Between The Trainers with The Assignments//
            t1.Courses.Add(c_3);
            t2.Courses.Add(c_3);
            t3.Courses.Add(c_3);
            t4.Courses.Add(c_3);
            t5.Courses.Add(c_3);
            _ = new Course()
            {
                Title = "JavaScript",
                Stream = "CB9",
                Type = "Part_Course",
                StartDate = new DateTime(2021, 1, 1),
                EndDate = new DateTime(2021, 7, 1),
            };
            //Each Course is Related to a List Of Students//
            c_4.Students = new List<Student>() { s_1, s_2, s_3, s_4, s_5 };
            //Each Course is Related to a List of Assignments
            c_4.Assignments = new List<Assignment>() { as_1, as_2, as_3, as_4, as_5 };
            //Each Course is Related to Multiple Trainers//
            c_4.Trainers = new List<Trainer>() { t1, t2 , t3, t4, t5 };
            // At this point We will start Creating the Relation Of the Student to the Course
            s_1.Course.Add(c_4);
            s_2.Course.Add(c_4);
            s_3.Course.Add(c_4);
            s_4.Course.Add(c_4);
            s_5.Course.Add(c_4);
            //Now We Will Start Creating The relation Between The Assignments with the Courses
            as_1.Course.Add(c_4);
            as_2.Course.Add(c_4);
            as_3.Course.Add(c_4);
            as_4.Course.Add(c_4);
            as_5.Course.Add(c_4);
            //At last We Will Create The relation Between The Trainers with The Assignments//
            t1.Courses.Add(c_4);
            t2.Courses.Add(c_4);
            t3.Courses.Add(c_4);
            t4.Courses.Add(c_4);
            t5.Courses.Add(c_4);
            _ = new Course()
            {
                Title = "Cobol",
                Stream = "CB10",
                Type = "Full_Course",
                StartDate = new DateTime(2021, 1, 1),
                EndDate = new DateTime(2021, 4, 1),
            };
            //Each Course is Related to a List Of Students//
            c_5.Students = new List<Student>() { s_1, s_2, s_3, s_4, s_5 };
            //Each Course is Related to a List of Assignments
            c_5.Assignments = new List<Assignment>() { as_1, as_2, as_3, as_4, as_5 };
            //Each Course is Related to Multiple Trainers//
            c_5.Trainers = new List<Trainer>() { t1, t2 , t3, t4, t5 };
            // At this point We will start Creating the Relation Of the Student to the Course
            s_1.Course.Add(c_5);
            s_2.Course.Add(c_5);
            s_3.Course.Add(c_5);
            s_4.Course.Add(c_5);
            s_5.Course.Add(c_5);
            //Now We Will Start Creating The relation Between The Assignments with the Courses
            as_1.Course.Add(c_5);
            as_2.Course.Add(c_5);
            as_3.Course.Add(c_5);
            as_4.Course.Add(c_5);
            as_5.Course.Add(c_5);
            //At last We Will Create The relation Between The Trainers with The Assignments//
            t1.Courses.Add(c_5);
            t2.Courses.Add(c_5);
            t3.Courses.Add(c_5);
            t4.Courses.Add(c_5);
            t5.Courses.Add(c_5);
            _ = new Course()
            {
                Title = "Cobol",
                Stream = "CB10",
                Type = "Part_Course",
                StartDate = new DateTime(2021, 1, 1),
                EndDate = new DateTime(2021, 7, 1),
            };
            //Each Course is Related to a List Of Students//
            c_6.Students = new List<Student>() { s_1, s_2, s_3, s_4, s_5 };
            //Each Course is Related to a List of Assignments
            c_6.Assignments = new List<Assignment>() { as_1, as_2, as_3, as_4, as_5 };
            //Each Course is Related to Multiple Trainers//
            c_6.Trainers = new List<Trainer>() { t1, t2 , t3, t4, t5 };
            // At this point We will start Creating the Relation Of the Student to the Course
            s_1.Course.Add(c_6);
            s_2.Course.Add(c_6);
            s_3.Course.Add(c_6);
            s_4.Course.Add(c_6);
            s_5.Course.Add(c_6);
            //Now We Will Start Creating The relation Between The Assignments with the Courses
            as_1.Course.Add(c_6);
            as_2.Course.Add(c_6);
            as_3.Course.Add(c_6);
            as_4.Course.Add(c_6);
            as_5.Course.Add(c_6);
            //At last We Will Create The relation Between The Trainers with The Assignments//
            t1.Courses.Add(c_6);
            t2.Courses.Add(c_6);
            t3.Courses.Add(c_6);
            t4.Courses.Add(c_6);
            t5.Courses.Add(c_6);
            _ = new Course()
            {
                Title = "C",
                Stream = "CB11",
                Type = "Full_Course",
                StartDate = new DateTime(2021, 1, 1),
                EndDate = new DateTime(2021, 4, 1),
            };
            //Each Course is Related to a List Of Students//
            c_7.Students = new List<Student>() { s_1, s_2, s_3, s_4, s_5 };
            //Each Course is Related to a List of Assignments
            c_7.Assignments = new List<Assignment>() { as_1, as_2, as_3, as_4, as_5 };
            //Each Course is Related to Multiple Trainers//
            c_7.Trainers = new List<Trainer>() { t1, t2 , t3, t4, t5 };
            // At this point We will start Creating the Relation Of the Student to the Course
            s_1.Course.Add(c_7);
            s_2.Course.Add(c_7);
            s_3.Course.Add(c_7);
            s_4.Course.Add(c_7);
            s_5.Course.Add(c_7);
            //Now We Will Start Creating The relation Between The Assignments with the Courses
            as_1.Course.Add(c_7);
            as_2.Course.Add(c_7);
            as_3.Course.Add(c_7);
            as_4.Course.Add(c_7);
            as_5.Course.Add(c_7);
            //At last We Will Create The relation Between The Trainers with The Assignments//
            t1.Courses.Add(c_7);
            t2.Courses.Add(c_7);
            t3.Courses.Add(c_7);
            t4.Courses.Add(c_7);
            t5.Courses.Add(c_7);
            _ = new Course()
            {
                Title = "C",
                Stream = "CB11",
                Type = "Part_Course",
                StartDate = new DateTime(2021, 1, 1),
                EndDate = new DateTime(2021, 7, 1),
            };
            //Each Course is Related to a List Of Students//
            c_8.Students = new List<Student>() { s_1, s_2, s_3, s_4, s_5 };
            //Each Course is Related to a List of Assignments
            c_8.Assignments = new List<Assignment>() { as_1, as_2, as_3, as_4, as_5 };
            //Each Course is Related to Multiple Trainers//
            c_8.Trainers = new List<Trainer>() { t1, t2 , t3, t4, t5 };
            // At this point We will start Creating the Relation Of the Student to the Course
            s_1.Course.Add(c_8);
            s_2.Course.Add(c_8);
            s_3.Course.Add(c_8);
            s_4.Course.Add(c_8);
            s_5.Course.Add(c_8);
            //Now We Will Start Creating The relation Between The Assignments with the Courses
            as_1.Course.Add(c_8);
            as_2.Course.Add(c_8);
            As_3.Course.Add(c_8);
            as_4.Course.Add(c_8);
            As_5.Course.Add(c_8);
            //At last We Will Create The relation Between The Trainers with The Assignments//
            t1.Courses.Add(c_8);
            t2.Courses.Add(c_8);
            t3.Courses.Add(c_8);
            t4.Courses.Add(c_8);
            t5.Courses.Add(c_8);
            #endregion
            #region MyData_For_Students
            //Creation Of Objects for the Class-Students//
            _ = new Student()
            {
                FirstName = "Antonis",
                LastName = "Chamalidis",
                DateOfBirth = new DateTime(1992, 5, 8),
                TuititionFees = null,
            };
            //The Student is Related With A List Of Assignments
            s_1.Assignments = new List<Assignment>() { as_1, as_2, as_3, as_4, as_5 };
            //The Student is Related With A List Of Trainers
            s_1.Trainers = new List<Trainer>() { t1, t2, t3, t4, t5 };
            //The Assignments are Also Related to the Student, So we will Have//
            as_1.Students.Add(s_1);
            as_2.Students.Add(s_1);
            as_3.Students.Add(s_1);
            as_4.Students.Add(s_1);
            As_5.Students.Add(s_1);
            //The Trainers are Also Related to the Student, So we will Have//
            t1.Students.Add(s_1);
            t2.Students.Add(s_1);
            t3.Students.Add(s_1);
            t4.Students.Add(s_1);
            t5.Students.Add(s_1);
            _ = new Student()
            {
                FirstName = "Alexandros",
                LastName = "Gazis",
                DateOfBirth = new DateTime(1993, 24, 10),
                TuititionFees = null,
            };
            //The Student is Related With A List Of Assignments
            s_2.Assignments = new List<Assignment>() { as_1, as_2, as_3, as_4, as_5 };
            //The Student is Related With A List Of Trainers
            s_2.Trainers = new List<Trainer>() { t1, t2, t3, t4, t5 };
            //The Assignments are Also Related to the Student, So we will Have//
            as_1.Students.Add(s_2);
            as_2.Students.Add(s_2);
            as_3.Students.Add(s_2);
            as_4.Students.Add(s_2);
            as_5.Students.Add(s_2);
            //The Trainers are Also Related to the Student, So we will Have//
            t1.Students.Add(s_2);
            t2.Students.Add(s_2);
            t3.Students.Add(s_2);
            t4.Students.Add(s_2);
            t5.Students.Add(s_2);
            _ = new Student()
            {
                FirstName = "Georgia",
                LastName = "Resta",
                DateOfBirth = new DateTime(1987, 24, 1),
                TuititionFees = null,
            };
            //The Student is Related With A List Of Assignments
            s_3.Assignments = new List<Assignment>() { as_1, as_2, as_3, as_4, as_5 };
            //The Student is Related With A List Of Trainers
            s_3.Trainers = new List<Trainer>() { t1, t2, t3, t4, t5 };
            //The Assignments are Also Related to the Student,So we will Have//
            as_1.Students.Add(s_3);
            as_2.Students.Add(s_3);
            as_3.Students.Add(s_3);
            as_4.Students.Add(s_3);
            as_5.Students.Add(s_3);
            //The Trainers are Also Related to the Student, So we will Have//
            t1.Students.Add(s_3);
            t2.Students.Add(s_3);
            t3.Students.Add(s_3);
            t4.Students.Add(s_3);
            t5.Students.Add(s_3);
            _ = new Student()
            {
                FirstName = "Panagiota",
                LastName = "Karatzouvali",
                DateOfBirth = new DateTime(1990, 27, 8),
                TuititionFees = null,
            };
            //The Student is Related With A List Of Assignments
            s_4.Assignments = new List<Assignment>() { as_1, as_2, as_3, as_4, as_5 };
            //The Student is Related With A List Of Trainers
            s_4.Trainers = new List<Trainer>() { t1, t2, t3, t4, t5 };
            //The Assignments are Also Related to the Student, So we will Have//
            as_1.Students.Add(s_4);
            as_2.Students.Add(s_4);
            as_3.Students.Add(s_4);
            as_4.Students.Add(s_4);
            as_5.Students.Add(s_4);
            //The Trainers are Also Related to the Student, So we will Have//
            t1.Students.Add(s_4);
            t2.Students.Add(s_4);
            t3.Students.Add(s_4);
            t4.Students.Add(s_4);
            t5.Students.Add(s_4);
            _ = new Student()
            {
                FirstName = "Giorgos",
                LastName = "Arampatzis",
                DateOfBirth = new DateTime(1980, 2, 8),
                TuititionFees = null,
            };
            //The Student is Related With A List Of Assignments
            s_5.Assignments = new List<Assignment>() { as_1, as_2, as_3, as_4, as_5 };
            //The Student is Related With A List Of Trainers
            s_5.Trainers = new List<Trainer>() { t1, t2, t3, t4, t5 };
                //The Assignments are Also Related to the Student, So we will Have//
                as_1.Students.Add(s_5);
            as_2.Students.Add(s_5);
            as_3.Students.Add(s_5);
            as_4.Students.Add(s_5);
            as_5.Students.Add(s_5);
            //The Trainers are Also Related to the Student, So we will Have//
            t1.Students.Add(s_5);
            t2.Students.Add(s_5);
            t3.Students.Add(s_5);
            t4.Students.Add(s_5);
            t5.Students.Add(s_5);





            #endregion
            #region MyData_For_Trainers
            //Create Objects For the Class-Trainers//
            _ = new Trainer()
            {
                FirstName = "Hektoras",
                LastName = "Gatsos",
            };
            //Each Trainer is Related to multiple Assignments
            t1.Assignments = new List<Assignment>() { as_1, as_2, as_3, as_4, as_5 };
            //Each Trainer is Related to multiple Assignments
            t1.Students = new List<Student>() { s_1, s_2, s_3, s_4, s_5 };
            //Each Trainer is Related to multiple Courses
            t1.Courses = new List<Course>() { C_1, C_2, c_3, c_4, c_5, c_6, c_7, c_8 };
            //Each Assignment is Related to the Trainer//
            as_1.Trainer.Add(t1);
            as_2.Trainer.Add(t1);
            as_3.Trainer.Add(t1);
            as_4.Trainer.Add(t1);
            as_5.Trainer.Add(t1);
            //Each Student is Related to the Trainer//
            s_1.Trainers.Add(t1);
            s_2.Trainers.Add(t1);
            s_3.Trainers.Add(t1);
            s_4.Trainers.Add(t1);
            s_5.Trainers.Add(t1);
            //Each Course is Related to the Trainer//
            C_1.Trainers.Add(t1);
            C_2.Trainers.Add(t1);
            c_3.Trainers.Add(t1);
            c_4.Trainers.Add(t1);
            c_5.Trainers.Add(t1);
            c_6.Trainers.Add(t1);
            c_7.Trainers.Add(t1);
            c_8.Trainers.Add(t1);
            _ = new Trainer()
            {
                FirstName = "Alexandros",
                LastName = "Sirakoulis",
            };
            //Each Trainer is Related to multiple Assignments
            t2.Assignments = new List<Assignment>() { as_1, as_2, as_3, as_4, as_5 };
            //Each Trainer is Related to multiple Assignments
            t2.Students = new List<Student>() { s_1, s_2, s_3, s_4, s_5 };
            //Each Trainer is Related to multiple Courses
            t2.Courses = new List<Course>() { C_1, C_2, c_3, c_4, c_5, c_6, c_7, c_8 };
            //Each Assignment is Related to the Trainer//
            as_1.Trainer.Add(t2);
            as_2.Trainer.Add(t2);
            as_3.Trainer.Add(t2);
            as_4.Trainer.Add(t2);
            As_5.Trainer.Add(t2);
            //Each Student is Related to the Trainer//
            s_1.Trainers.Add(t2);
            s_2.Trainers.Add(t2);
            s_3.Trainers.Add(t2);
            s_4.Trainers.Add(t2);
            s_5.Trainers.Add(t2);
            //Each Course is Related to the Trainer//
            C_1.Trainers.Add(t2);
            C_2.Trainers.Add(t2);
            c_3.Trainers.Add(t2);
            c_4.Trainers.Add(t2);
            c_5.Trainers.Add(t2);
            c_6.Trainers.Add(t2);
            c_7.Trainers.Add(t2);
            c_8.Trainers.Add(t2);
            _ = new Trainer()
            {
                FirstName = "Maria",
                LastName = "Barla",
            };
            //Each Trainer is Related to multiple Assignments
            t3.Assignments = new List<Assignment>() { as_1, as_2, as_3, as_4, as_5 };
            //Each Trainer is Related to multiple Assignments
            t3.Students = new List<Student>() { s_1, s_2, s_3, s_4, s_5 };
            //Each Trainer is Related to multiple Courses
            t3.Courses = new List<Course>() { C_1, C_2, c_3, c_4, c_5, c_6, c_7, c_8 };
            //Each Assignment is Related to the Trainer//
            as_1.Trainer.Add(t3);
            as_2.Trainer.Add(t3);
            As_3.Trainer.Add(t3);
            as_4.Trainer.Add(t3);
            As_5.Trainer.Add(t3);
            //Each Student is Related to the Trainer//
            s_1.Trainers.Add(t3);
            s_2.Trainers.Add(t3);
            s_3.Trainers.Add(t3);
            s_4.Trainers.Add(t3);
            s_5.Trainers.Add(t3);
            //Each Course is Related to the Trainer//
            C_1.Trainers.Add(t3);
            C_2.Trainers.Add(t3);
            c_3.Trainers.Add(t3);
            c_4.Trainers.Add(t3);
            c_5.Trainers.Add(t3);
            c_6.Trainers.Add(t3);
            c_7.Trainers.Add(t3);
            c_8.Trainers.Add(t3);
            _ = new Trainer()
            {
                FirstName = "Konstantina",
                LastName = "Lalioti",
            };
            //Each Trainer is Related to multiple Assignments
            t4.Assignments = new List<Assignment>() { as_1, as_2, as_3, as_4, as_5 };
            //Each Trainer is Related to multiple Assignments
            t4.Students = new List<Student>() { s_1, s_2, s_3, s_4, s_5 };
            //Each Trainer is Related to multiple Courses
            t4.Courses = new List<Course>() { C_1, C_2, c_3, c_4, c_5, c_6, c_7, c_8 };
            //Each Assignment is Related to the Trainer//
            as_1.Trainer.Add(t4);
            as_2.Trainer.Add(t4);
            as_3.Trainer.Add(t4);
            as_4.Trainer.Add(t4);
            As_5.Trainer.Add(t4);
            //Each Student is Related to the Trainer//
            s_1.Trainers.Add(t4);
            s_2.Trainers.Add(t4);
            s_3.Trainers.Add(t4);
            s_4.Trainers.Add(t4);
            s_5.Trainers.Add(t4);
            //Each Course is Related to the Trainer//
            C_1.Trainers.Add(t4);
            C_2.Trainers.Add(t4);
            c_3.Trainers.Add(t4);
            c_4.Trainers.Add(t4);
            c_5.Trainers.Add(t4);
            c_6.Trainers.Add(t4);
            c_7.Trainers.Add(t4);
            c_8.Trainers.Add(t4);
            _ = new Trainer()
            {
                FirstName = "Giannis",
                LastName = "Seretis",
            };
            //Each Trainer is Related to multiple Assignments
            t5.Assignments = new List<Assignment>() { as_1, as_2, as_3, as_4, as_5 };
            //Each Trainer is Related to multiple Assignments
            t5.Students = new List<Student>() { s_1, s_2, s_3, s_4, s_5 };
            //Each Trainer is Related to multiple Courses
            t5.Courses = new List<Course>() { C_1, C_2, c_3, c_4, c_5, c_6, c_7, c_8 };
            //Each Assignment is Related to the Trainer//
            as_1.Trainer.Add(t5);
            as_2.Trainer.Add(t5);
            as_3.Trainer.Add(t5);
            as_4.Trainer.Add(t5);
            as_5.Trainer.Add(t5);
            //Each Student is Related to the Trainer//
            s_1.Trainers.Add(t5);
            s_2.Trainers.Add(t5);
            s_3.Trainers.Add(t5);
            s_4.Trainers.Add(t5);
            s_5.Trainers.Add(t5);
            //Each Course is Related to the Trainer//
            C_1.Trainers.Add(t5);
            C_2.Trainers.Add(t5);
            c_3.Trainers.Add(t5);
            c_4.Trainers.Add(t5);
            c_5.Trainers.Add(t5);
            c_6.Trainers.Add(t5);
            c_7.Trainers.Add(t5);
            c_8.Trainers.Add(t5);

            #endregion
            #region MyData_For_Assignments
            // Creating an Object//

            _ = new Assignment()
            {
                Title = "Assigment A",
                Description = "Create one Private Schooll",
                Submission = new DateTime(2021, 3, 25),
                OralMark = null,
                Total = null
            };
            new Assignment()
            {
                Title = "Assigment A",
                Description = "Create one Private Schooll",
                Submission = new DateTime(2021, 3, 25),
                OralMark = null,
                Total = null
            }.Students = new List<Student>() { s_1, s_2, s_3, s_4, s_5 };
            // As well as Each student is related to The assignments//
            s_1.Assignments.Add(new Assignment()
            {
                Title = "Assigment A",
                Description = "Create one Private Schooll",
                Submission = new DateTime(2021, 3, 25),
                OralMark = null,
                Total = null
            });
            s_2.Assignments.Add(new Assignment()
            {
                Title = "Assigment A",
                Description = "Create one Private Schooll",
                Submission = new DateTime(2021, 3, 25),
                OralMark = null,
                Total = null
            });
            s_3.Assignments.Add(new Assignment()
            {
                Title = "Assigment A",
                Description = "Create one Private Schooll",
                Submission = new DateTime(2021, 3, 25),
                OralMark = null,
                Total = null
            });
            s_4.Assignments.Add(new Assignment()
            {
                Title = "Assigment A",
                Description = "Create one Private Schooll",
                Submission = new DateTime(2021, 3, 25),
                OralMark = null,
                Total = null
            });
            s_5.Assignments.Add(new Assignment()
            {
                Title = "Assigment A",
                Description = "Create one Private Schooll",
                Submission = new DateTime(2021, 3, 25),
                OralMark = null,
                Total = null
            });
            _ = new Assignment()
            {
                Title = "Assigment B",
                Description = "Create one Private Hotel",
                Submission = new DateTime(2021, 5, 25),
                OralMark = null,
                Total = null
            };
            // An assigment Has a list of Students//
            as_2.Students = new List<Student>() { s_1, s_2, s_3, s_4, s_5 };
            // As well as Each student is related to The assignments//
            s_1.Assignments.Add(as_2);
            s_2.Assignments.Add(as_2);
            s_3.Assignments.Add(as_2);
            s_4.Assignments.Add(as_2);
            s_5.Assignments.Add(as_2);
            _ = new Assignment()
            {
                Title = "Assigment B",
                Description = "Create one Private University",
                Submission = new DateTime(2021, 5, 25),
                OralMark = null,
                Total = null
            };
            // An assigment Has a list of Students//
            as_3.Students = new List<Student>() { s_1, s_2, s_3, s_4, s_5 };
            // As well as Each student is related to The assignments//
            s_1.Assignments.Add(as_3);
            s_3.Assignments.Add(as_3);
            s_5.Assignments.Add(as_3);
            _ = new Assignment()
            {
                Title = "Assigment C",
                Description = "Create one Private University",
                Submission = new DateTime(2021, 5, 25),
                OralMark = null,
                Total = null
            };
            // An assigment Has a list of Students//
            as_4.Students = new List<Student>() { s_1, s_2, s_3, s_4, s_5 };
            // As well as Each student is related to The assignments//
            s_1.Assignments.Add(as_4);
            s_2.Assignments.Add(as_4);
            s_3.Assignments.Add(as_4);
            s_4.Assignments.Add(as_4);
            s_5.Assignments.Add(as_4);
            _ = new Assignment()
            {
                Title = "Assigment B",
                Description = "Create one Eshop",
                Submission = new DateTime(2021, 5, 25),
                OralMark = null,
                Total = null
            };
            // An assigment Has a list of Students//
            as_5.Students = new List<Student>() { s_1, s_2, s_3, s_4, s_5 };
            // As well as Each student is related to The assignments//
            s_1.Assignments.Add(as_5);
            s_2.Assignments.Add(as_5);
            s_3.Assignments.Add(as_5);
            s_4.Assignments.Add(as_5);
            s_5.Assignments.Add(as_5);



            #endregion
        }
    }
}
