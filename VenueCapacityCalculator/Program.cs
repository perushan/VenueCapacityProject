using System;
using System.Collections.Generic;

namespace VenueCapacityCalculator
{
    class Program
    {
        public static List<report1> venueList = new List<report1>();

        public static void printReport()
        {
            string details = "\n********************************************************\n" + "VENUE CAPACITY REPORT\n" + "********************************************************\n";
            details += "\nVENUE CAPACITY\t\tSTUDENTS\t\tEXCESS/DEFICIT";
            Console.WriteLine(details);
            
            foreach (report1 item in venueList)
            {
                Console.WriteLine(item.getCapacity() + "\t\t\t" + item.getStudents() + "\t\t\t" + item.Calculate());
            }

        }

        static void Main(string[] args)
        {
            bool venue = true;
            report1 obj = null;
            
            while (venue)
            {
                Console.WriteLine("Welcome");
                Console.WriteLine("Enter the capacity of the venue");
                int capacity = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter The Number Of Students");
                int students = Int32.Parse(Console.ReadLine());
                
                obj = new report1(students, capacity); //create object of report
                venueList.Add(obj);

                //add obj to array
                Console.WriteLine("Do you want to add another venue? Enter Y");

                if (Console.ReadLine() != "Y")
                {
                    venue = false;
                    Console.WriteLine("Do you want to print a venue capacity report? Enter Y");

                    if (Console.ReadLine() == "Y")
                    {
                        printReport();
                    }
                }
               

            }

            //loop through array and use tostring method 
            /*
            loop through array 
            each element of array use to string method
            */

        }
    }
}
