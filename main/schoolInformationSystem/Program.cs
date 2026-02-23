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
            List<Person> people = new List<Person>();
           
            string uSelect = "";
            
            //looping to get student info    
            Console.WriteLine("");
            
           while((uSelect != "3") && (c.students.Count <= 30))
            {
                Console.WriteLine("1. Input Student information");
                Console.WriteLine("2. show student info");
                Console.WriteLine("3. exit");
                Console.WriteLine("");
                Console.Write("Enter your selection: ");

                uSelect = Console.ReadLine();

                int num = int.Parse(uSelect);
                switch (num)
                {
                    case 1:
                    {
                        
                        
                        bool valid = false; 

                        Console.WriteLine("");
                        Student s = new Student();
                        Console.Write("enter Student Name:");
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

                        c.EnrollStudent(s);                        

                        Console.WriteLine("");
                        break;
                    } 
                    case 2:
                    {
                        
                        
                        break;
                    }
                    
                }


            Console.WriteLine($"Number of student: {c.students.Count}");
                        
            }
           
        }
            
    }    
}
