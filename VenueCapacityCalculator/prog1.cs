using System;


namespace VenueCapacityCalculator
{
    public class report1
    {
        private int students;
        private int capacity;

        public report1(int students, int capacity)
        {
            this.students = students;
            this.capacity = capacity;
        }

        public int getStudents()
        {
            return students;
        }

        public void setStudents(int students)
        {
            this.students = students;
        }

        public int getCapacity()
        {
            return capacity;
        }

        public void setCapacity(int capacity)
        {
            this.capacity = capacity;
        }

        public string Calculate()
        {
            //do capacity calculations
            //make structured return string
            if (capacity>students)
            {
                int total = capacity - students;
                return "The deficit of students are " + total;
            }
            else
            {
                int total = students - capacity;
                return "The excess students are " + total;
            }

        }

    }
}
