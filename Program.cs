using System;

namespace VenueCapacityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool venue = true;
            
            while (venue == true)
            {
                Console.WriteLine("Welcome");
                Console.WriteLine("Enter the capacity of the venue");
                int capacity = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter The Number Of Students");
                int students = Int32.Parse(Console.ReadLine());
                Console.WriteLine("The Number Of Students are " + students);
          
                if (capacity>students)
                {
                     int total = capacity - students;
                     Console.WriteLine("There are " + total + " seats available");
                     break;
                 }
                else
                {
                     Console.WriteLine("The Venue has reached maximum capacity\n");
                     int total = students - capacity;
                     Console.WriteLine("There are " + total + " extra students");
                     Console.WriteLine(total + " need to move to another venue");
                     break;
                }

                Console.WriteLine("Do you want to add another venue? Enter Yes or No");

                report1 obj = new report1(students,capacity);

                
            }

        }
    }
}
