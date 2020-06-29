using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Current Gradebook");
            book.AddGrade(99.9);
            book.AddGrade(88.8);
            book.AddGrade(77.7);
            var stats = book.GetStats();
            Console.WriteLine($"Average: {stats.Average}");
            Console.WriteLine($"High: {stats.High}");
            Console.WriteLine($"LOw: {stats.Low}");
        }
    }
}
