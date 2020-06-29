using System;
using Xunit;

namespace GradeBook.test
{
    public class BookTests
    {
        [Fact]
        public void BookHiMedLoResults()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(75.2);
            book.AddGrade(74.2);
            book.AddGrade(73.2);

            // act
            var stats = book.GetStats();

            // assert
            Assert.Equal(74.2, stats.Average);
            Assert.Equal(75.2, stats.High);
            Assert.Equal(73.2, stats.Low);
        }
    }
}
