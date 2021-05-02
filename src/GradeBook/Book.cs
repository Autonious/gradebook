using System;
using System.Collections.Generic;
namespace GradeBook

{
    class Book
    {
        public Book(string name) // explicit constructor
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStats()
        {
            var avgGrade = 0.0;
            var totalGrade = 0.0;
            var highestGrade = double.MinValue;
            var lowestGrade = double.MaxValue;
            if (grades.Count > 0)
            {
                foreach (var number in grades)
                {
                    highestGrade = Math.Max(number, highestGrade);
                    lowestGrade = Math.Min(number, lowestGrade);
                    totalGrade += number;
                }
                avgGrade = (totalGrade /= grades.Count);
                Console.WriteLine($"The lowest grade is {lowestGrade}.");
                Console.WriteLine($"The highest grade is {highestGrade}.");
                Console.WriteLine($"The average grade is {avgGrade:N3}.");
            }
            else
            {
                Console.WriteLine($"{name} is empty. Please add grades to the system.");
            }

        }

        internal void DeleteAllGrades()
        {
            grades = new List<double> { };
        }

        private List<double> grades; // Because this is outside of the void, it is known as a Field for the class, in this case a field for the "Book" class. The Book Class saves this Field in memory.
        private string name;
    }


}