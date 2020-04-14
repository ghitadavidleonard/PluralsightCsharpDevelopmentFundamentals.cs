﻿using CSharpFundamentals;
using System;
using Xunit;

namespace XUnitCSharpFundamentals
{
    // define a var that can point to and invoke different methods. When defining a delegate you are defining what a method has to look like
    public delegate string WriteLogDelegate(string logMessage);

    public class TypeTests
    {
        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log;

            log = ReturnMessage;

            var result = log("Hello!");
            Assert.Equal("Hello!", result);
        }

        string ReturnMessage(string message)
        {
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
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Jersey");

            Assert.Equal("New Jersey", book1.Name);
        }

        void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }


        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferencesSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
        }


        Book GetBook(string name)
        {
            return new Book(name);
        }

        void SetName(Book book, string name)
        {
            book.Name = name;
        }
    }
}