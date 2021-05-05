using System;
using System.Collections.Generic;


namespace GradeBook
{
    class Program
    {
        static void Main(string[] args) // Method named "Main"
        {
            var book = new Book("Datwon's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.1);
            book.AddGrade(77.5);

            var stats = book.GetStats();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The highest grade is {stats.Average:N1}");
        }
    }
}
