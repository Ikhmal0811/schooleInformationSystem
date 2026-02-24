namespace SchoolSystem
{
    public class FullTimeTeacher : Teacher
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Full Time Teacher");
            base.DisplayInfo();
        }
    }    
}