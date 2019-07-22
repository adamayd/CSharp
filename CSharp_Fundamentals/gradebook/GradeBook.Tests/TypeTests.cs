using System;
using Xunit;
using GradeBook.Console;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void SetValueFromRef()
        {
            // arrange
            var x = GetInt();

            // act
            SetInt(ref x);

            // assert
            Assert.Equal(42, x);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            // arrange
            var book1 = GetBook("Book 1");

            // act
            SetName(book1, "New Name");

            // assert
            Assert.Equal("New Name", book1.Name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            // arrange
            var book1 = GetBook("Book 1");

            // act
            GetBookSetName(book1, "New Name");

            // assert
            Assert.Equal("Book 1", book1.Name);
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            // arrange
            var book1 = GetBook("Book 1");

            // act
            GetRefBookSetName(ref book1, "New Name");

            // assert
            Assert.Equal("New Name", book1.Name);
        }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            // arrange
            string name = "Adam";

            // act
            var upper = MakeUppercase(name);

            // assert
            Assert.Equal("Adam", name);
            Assert.Equal("ADAM", upper);

        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            // arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            // act

            // assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            // arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;

            // act

            // assert
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        private int GetInt()
        {
            return 3;
        }

        private void SetInt(ref int z)
        {
            z = 42;
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        private string MakeUppercase(string parameter)
        {
            return parameter.ToUpper();
        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        private void GetRefBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }
    }
}
