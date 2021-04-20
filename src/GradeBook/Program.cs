using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args) // Method named "Main"
        {
            var grades = new List<double>() {12.8, 78.2, 7.23, 921.1};
            grades.Add(57.6);
            

            var result = 0.0;
            foreach(var number in grades)
            {
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N3}");           
            if(args.Length > 0)
            {
                 Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
