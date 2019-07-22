using System;
using Xunit;
using GradeBook.Console;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High);
            Assert.Equal(77.3, result.Low);
            Assert.Equal('B', result.Letter);
        }

        [Fact]
        public void GreaterThanZeroLessThanOneHundred()
        {
            // arrange
            var book = new Book("Test");

            // act
            var grade1 = book.AddGrade(-2.0);
            var grade2 = book.AddGrade(105);
            var grade3 = book.AddGrade(88);

            // assert
            Assert.Equal(-1, grade1);
            Assert.Equal(-1, grade2);
            Assert.Equal(0, grade3);
        }
    }
}
