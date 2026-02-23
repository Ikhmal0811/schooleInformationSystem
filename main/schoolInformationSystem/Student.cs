namespace SchoolSystem
{
     public class Student : Person
    {
        private string studentID;

        public string StudentID
        {
            get {return studentID;}
            set {studentID = value;}
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"ID: {Id}");
        }
    }
}