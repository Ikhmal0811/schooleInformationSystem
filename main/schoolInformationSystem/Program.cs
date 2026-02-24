using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace SchoolSystem
{
       

//Main Class
    class Program
    {
        static void Main(string[] args)
        {
                
           Course c = new Course();
            List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();
            List<Course> courses = new List<Course>();
           
            string uSelect = "";
            
            //looping to get student info    
            Console.WriteLine("");
            
           while((uSelect != "7") && (c.students.Count <= 30))
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Teacher");
                Console.WriteLine("3. Add Course");
                Console.WriteLine("4. Assign Student to Course");
                Console.WriteLine("5. Assign Teacher to Course");
                Console.WriteLine("6. Display Info");
                Console.WriteLine("7. Exit");
                Console.WriteLine("");
                Console.Write("Enter your selection: ");

                uSelect = Console.ReadLine();

                int num = int.Parse(uSelect);
                switch (num)
                {
                    case 1:
                    {
                        
                        Console.WriteLine("\n1. Part time");
                        Console.WriteLine("2. Full time");

                        Console.Write("Enter your selection");
                        int studentStatus = int.Parse(Console.ReadLine());

                       Student s = new Student();
                        if(studentStatus == 1)
                            {
                                Console.WriteLine("You Select Part time");
                                s = new PartTimeStudent();
                            }
                            else
                            {
                                Console.WriteLine("You Select Full time");
                                s = new FullTimeStudent();
                            }

                        bool valid = false; 

                        
                        
                        Console.Write("\n Enter Student Name:");
                        s.Name = Console.ReadLine();

                        //for the age input, making sure it not crashing if user input non number.
                        while(!valid)
                            {
                                Console.Write("enter Student Age:");
                                try
                                {
                                    int ageInput = int.Parse(Console.ReadLine());

                                    if(ageInput > 0)
                                    {
                                        s.Age = ageInput;
                                        valid = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("age must be positve.");
                                    }                                    
                                }
                                catch
                                {
                                    Console.WriteLine("not a valid age, try again.");
                                }
                            }
                        
                        Console.Write("enter ID:");
                        s.Id = Console.ReadLine();
                        Console.Write("enter Student ID:");
                        s.StudentID = Console.ReadLine();

                        students.Add(s);

                        c.EnrollStudent(s);                        

                        Console.WriteLine("");
                        break;
                    } 
                    case 2:
                    {
                        Teacher t = new Teacher();
                        Console.WriteLine("\n1. Part time");
                        Console.WriteLine("2. Full time");

                        Console.Write("Enter your selection");
                        int teacherStatus = int.Parse(Console.ReadLine());
                        if(teacherStatus == 1)
                            {
                                Console.WriteLine("You Select Part time");
                                t = new PartTimeTeacher();
                            }
                            else
                            {
                                Console.WriteLine("You Select Full time");
                                t = new FullTimeTeacher();
                            }
                        
                        bool valid = false; 

                        
                        
                        Console.Write("\nEnter Teacher Name:");
                        t.Name = Console.ReadLine();

                        //for the age input, making sure it not crashing if user input non number.
                        while(!valid)
                            {
                                Console.Write("enter Teacher Age:");
                                try
                                {
                                    int ageInput = int.Parse(Console.ReadLine());

                                    if(ageInput > 0)
                                    {
                                        t.Age = ageInput;
                                        valid = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("age must be positve.");
                                    }                                    
                                }
                                catch
                                {
                                    Console.WriteLine("not a valid age, try again.");
                                }
                            }
                        
                        Console.Write("enter ID:");
                        t.Id = Console.ReadLine();
                        teachers.Add(t);
                        
                        

                        
                        break;
                    }
                    
                }


            Console.WriteLine($"Number of student: {c.students.Count}\n");
                        
            }
           
        }
            
    }    
}
