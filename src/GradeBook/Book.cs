using System;
using System.Collections.Generic;
namespace GradeBook

{
    public class Book
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

        public Stats GetStats()
        {
            var result = new Stats();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
           
            foreach (var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }
            result.Average /= grades.Count;

            return result;
        }

        private List<double> grades; // Because this is outside of the void, it is known as a Field for the class, in this case a field for the "Book" class. The Book Class saves this Field in memory.
        private string name;
    }


}