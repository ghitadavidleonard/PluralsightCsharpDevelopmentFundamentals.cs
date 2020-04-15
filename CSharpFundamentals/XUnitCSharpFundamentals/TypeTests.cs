using CSharpFundamentals;
using System;
using Xunit;

namespace XUnitCSharpFundamentals
{
    // define a var that can point to and invoke different methods. When defining a delegate you are defining what a method has to look like
    public delegate string WriteLogDelegate(string logMessage);

    public class TypeTests
    {
        int count = 0;
        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = ReturnMessage;

            log += ReturnMessage;
            log += IncrementCount;

            var result = log("Hello!");
            Assert.Equal(3, count);
        }

        string IncrementCount(string message)
        {
            count++;
            return message.ToLower();
        }

        string ReturnMessage(string message)
        {
            count++;
            return message;
        }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Scott";
            var upper = MakeUppercase(name);

            Assert.Equal("Scott", name);
            Assert.Equal("SCOTT", upper);
        }

        private string MakeUppercase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void Test1()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        int GetInt() => 3;

        void SetInt(ref int x) => x = 42;

        [Fact]
        public void CSharpIsPassedByValue()
        {
            var book1 = GetBook("InMemoryBook 1");
            GetBookSetName(ref book1, "New Jersey");

            Assert.Equal("New Jersey", book1.Name);
        }

        void GetBookSetName(ref InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("InMemoryBook 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }


        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("InMemoryBook 1");
            var book2 = GetBook("InMemoryBook 2");

            Assert.Equal("InMemoryBook 1", book1.Name);
            Assert.Equal("InMemoryBook 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferencesSameObject()
        {
            var book1 = GetBook("InMemoryBook 1");
            var book2 = book1;

            Assert.Same(book1, book2);
        }


        InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }

        void SetName(InMemoryBook book, string name)
        {
            book.Name = name;
        }
    }
}