using NUnit.Framework;

namespace UnitTestProject_Lab2
{
    [TestFixture]
    public class StackTest1
    {
        [Test]
        public void Push_obj()
        {
            var stack = new Stack<string>();

            // Assert.IsTrue(false);

            stack.Push("asa");

            Assert.AreEqual(1, stack.Count);
        }

        [Test]
        public void Push_obj2()
        {
            var stack = new Stack<string>();

            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Pop_obj()
        {
            var stack = new Stack<string>();

            // Assert.IsTrue(false);
            stack.Push("asa");
            var result = stack.Pop();

            Assert.AreEqual("asa", result);
        }

        [Test]
        public void Pop_obj1()
        {
            var stack = new Stack<string>();

            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_obj2()
        {
            var stack = new Stack<string>();
            stack.Push("asa");
            stack.Peek();

            Assert.AreNotEqual(1, stack.Count - 1);

        }

        [Test]
        public void Peek_obj1()
        {
            var stack = new Stack<string>();

            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }


       



    }
}
