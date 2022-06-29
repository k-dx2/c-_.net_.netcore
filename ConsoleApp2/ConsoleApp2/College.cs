using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class College
    {
        List<Student> listStudents;
        public College()
        {
            listStudents = new List<Student>();

         }

        public string AddStudent(Student s)
        {
            listStudents.Add(s);
            return "Student added successfully";
        }

        public List<Student> GetStudents()
        {
            return listStudents;
        }


    }
}
