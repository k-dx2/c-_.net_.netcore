using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class College
    {
        List<Student> liststud;

        public College()
        {
            liststud = new List<Student>();
        }

        public string AddStud(Student s)
        {
            liststud.Add(s);
            return "Added Successfully";
        }

        public List<Student> getstud()
        {
            return liststud;
        }
    }
}
