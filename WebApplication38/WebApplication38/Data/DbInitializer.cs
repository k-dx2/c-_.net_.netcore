﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication38.Models;

namespace WebApplication38.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{LastName="Alexander",FirstMidName="Carson",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{LastName="Alonso", FirstMidName = "Meredith",EnrollmentDate =DateTime.Parse("2002-09-01")},
            new Student{LastName="Anand",FirstMidName="Arturo",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{LastName = "Barzdukas", FirstMidName = "Gytis",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{LastName = "Li", FirstMidName = "Yan",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{LastName = "Justice", FirstMidName = "Peggy",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{LastName = "Norman", FirstMidName = "Laura",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{LastName = "Olivetto", FirstMidName = "Nino",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
            new Course{CourseID=1045,Title="Calculus",Credits=4},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4},
            new Course{CourseID=2021,Title="Composition",Credits=3},
            new Course{CourseID=2042,Title="Literature",Credits=4}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=1050},
            new Enrollment{StudentID=1,CourseID=4022},
            new Enrollment{StudentID=1,CourseID=4041},
            new Enrollment{StudentID=2,CourseID=1045},
            new Enrollment{StudentID=2,CourseID=3141},
            new Enrollment{StudentID=2,CourseID=2021},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=4022},
            new Enrollment{StudentID=5,CourseID=4041},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}

