using System;


namespace VenueCapacityCalculator
{
    public class report1
    {
        private static int students;
        private static int capacity;

        public report1(string students, string capacity)
        {
            this.students = students;
            this.capacity = capacity;
        }

        public string getStudents()
        {
            return students;
        }

        public void setStudents(string students)
        {
            this.students = students;
        }

        public string getCapacity()
        {
            return capacity;
        }

        public void setCapacity(string capacity)
        {
            this.capacity = capacity;
        }

    }
}
