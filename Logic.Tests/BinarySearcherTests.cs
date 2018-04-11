using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;

namespace Logic.Tests
{
    [TestFixture]
    public class BinarySearcherTests
    {
        [TestCase(new []{1,4,7,23,95,122,178}, 122, ExpectedResult = 5)]
        public int BinarySearch_NormalSearch_IntArray(int[] array, int item)
        {
            return array.Search(item);
        }

        [TestCase(new[] { "A", "B", "D", "N", "S", "X" }, "B", ExpectedResult = 1)]
        public int BinarySearch_NormalSearch_StringArray(string[] array, string item)
        {
            return array.Search(item);
        }

        [TestCase()]
        public void BinarySearch_NullArray_Exception()
        {
            int[] array = null;
            Assert.Catch<ArgumentNullException>(() => array.Search(5));
        }

        [TestCase()]
        public void BinarySearch_TypeIsNotComparable_Exception()
        {
            IEnumerable<int>[] array = { new List<int>(), new List<int>(), new List<int>(), new List<int>() };
            Assert.Catch<InvalidCastException>(() => array.Search(new List<int>()));
        }
    }
}
