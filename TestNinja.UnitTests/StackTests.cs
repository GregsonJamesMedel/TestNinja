
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void Push_InputIsNull_ThrowsArgumentNullException()
        {
            var stack = new Stack<string>();
            
            Assert.ThrowsException<ArgumentNullException>(() => stack.Push(null));
        }

        [TestMethod]
        public void Push_InputIsValid_AddInputToList()
        {
            var stack = new Stack<string>();

            stack.Push("abc");

            Assert.AreEqual(1,stack.Count);
        }

        [TestMethod]
        public void Pop_ListIsEmpty_ThrowsInvalidOperationException()
        {
            var stack = new Stack<string>();

            Assert.ThrowsException<InvalidOperationException>(() => stack.Pop());
        }

        [TestMethod]
        public void Pop_ListIsNotEmpty_ReturnTheLastInputInList()
        {
            var stack = new Stack<string>();

            stack.Push("abc");
            stack.Push("efg");

            Assert.AreEqual("efg",stack.Pop());
        }

        [TestMethod]
        public void Pop_ListIsNotEmpty_ShouldRemoveLastElementInList()
        {
            var stack = new Stack<string>();

            stack.Push("abc");
            stack.Push("efg");

            stack.Pop();

            Assert.AreEqual(1,stack.Count);
        }

        [TestMethod]
        public void Peek_InputIsNull_ThrowsInvalidOperationException()
        {
            var stack = new Stack<string>();

            Assert.ThrowsException<InvalidOperationException>(() => stack.Peek());
        }

        [TestMethod]
        public void Peek_InputIsValid_ReturnLastInputInList()
        {
            var stack = new Stack<string>();

            stack.Push("abc");
            stack.Push("def");
            var result = stack.Peek();

            Assert.AreEqual("def",result);
        }
    }
}