using System;
using Xunit;

namespace GradeBook.test
{
    public class TypeTest
    {
        
        [Fact]
        public void StringsActLikeVal()
        {
            string x = "Poop";
            var returnString = MakeUppercase(x);
            Assert.Equal("Poop", x);
            Assert.Equal("POOP", returnString);
        }

        private string MakeUppercase(string param)
        {
            return param.ToUpper();
        }

        [Fact]
        public void Test1()
        {
            var x = GetInt();
            Assert.Equal(3, x);
            SetInt(ref x);
            Assert.Equal(15, x);
            
        }

        private void SetInt(ref int x)
        {
            x = 15;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void PassByRef()
            {
                // arrange
                var book1 = GetBook("Book 1");
                
                // act
                GetBookSetNameRef(ref book1, "New Name");
               
                // assert
                Assert.Equal("New Name", book1.Name);

        }

        private void GetBookSetNameRef(ref Book book, string name)
        {
            book = new Book(name);
        }


        [Fact]
        public void PassByValue()
            {
                // arrange
                var book1 = GetBook("Book 1");
                
                // act
                GetBookSetNameVal(book1, "New Name");
               
                // assert
                Assert.Equal("Book 1", book1.Name);

        }

        private void GetBookSetNameVal(Book book, string name)
        {
            book = new Book(name);
        }


        [Fact]
        public void GetBookReturnsUnique()
        {
            // arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            // act

            // assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
            Assert.NotEqual(book1.Name, book2.Name);



        }


        [Fact]
        public void DoubleReference()
        {
            // arrange
            var book1 = GetBook("Book 1");

            // act
            var book2 = book1;

            // assert
            Assert.Same(book1, book2);
            Assert.IsNotType<string>(book1);


        }


        [Fact]
        public void ReturnsObject()
        {
            // arrange
            var book1 = GetBook("Book 1");


            // act
            var book2 = book1;

            // assert
            Assert.IsNotType<string>(book1);
            Assert.IsType<Book>(book1);
            Assert.IsType<Book>(book2);
        }

        
        Book GetBook(string name)
        {
            return new Book(name);
        }
        

        
    }
}
