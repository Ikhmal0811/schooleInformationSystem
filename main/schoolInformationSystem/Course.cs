using System;
using System.Collections.Generic;

namespace SchoolSystem
{
        public class Course
    {    
        public string CourseName;
        public string CourseCode;
    //reference to Teacher class
        public Teacher courseTeacher{ get; set;}

    //reference to student class
        public List<Student> students {get; set;} = new List<Student>();

        public int maxCapacity = 30;    

        public void EnrollStudent(Student s)
        {
            if (students.Count < maxCapacity)
            {
                students.Add(s);
                Console.WriteLine($"Student {s.Name} enrolled successfully");
            }
            else
            {
                Console.WriteLine($"Student {s.Name} failed to enrolled. Maximum capacity reached.");
            }
        }
    }    
}
