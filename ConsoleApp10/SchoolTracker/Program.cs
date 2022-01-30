using System;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentGrades = new int[10](80, 77, 45, 87, 69, 52, 99, 85, 78, 91);

            foreach (var studentGrade in studentGrades)
            {
                Console.WriteLine(studentGrade);
            }
            

        }
    }
}
