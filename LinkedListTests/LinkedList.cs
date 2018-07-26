
using System;
using System.Linq;
using NUnit.Framework;
using LinkedList;

namespace LinkedListTests
{
    [TestFixture]
    public class LinkedList
    {
        [Test]
        [TestCase(new [] {1,2,3}, 2)]
        [TestCase(new[] { 1, 2, 3, 4}, 2)]
        [TestCase(new[] { 1, 2, 3, 4, 5}, 3)]
        [TestCase(new int [0], default(int))]
        public void Given_Elements_When_Adding_To_LinkedList_Then_Middle_Element_Should_Be_As_Follow(int[] arrayOfElements, int expectedElement)
        {
            var linkedList = new LinkedList<int>();
            arrayOfElements.ToList().ForEach(i => linkedList.Add(i));

            var result = linkedList.MiddleElement();
            Assert.That(result, Is.EqualTo(expectedElement), "Expected element at middle position: {0}", expectedElement);
        }
    }
}
