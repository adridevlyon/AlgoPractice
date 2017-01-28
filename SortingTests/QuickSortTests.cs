using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sorting.Tests
{
    [TestClass()]
    public class QuickSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            List<int> input = null;
            QuickSort.Sort(input);
            Assert.IsNull(input);

            input = new List<int>();
            QuickSort.Sort(input);
            Assert.AreEqual(0, input.Count);

            input = new List<int> { 5 };
            QuickSort.Sort(input);
            Assert.AreEqual(1, input.Count);
            Assert.AreEqual(5, input[0]);

            input = new List<int> { 5, 4, 1, 8, 6, 7, 3, 5, 0, 9, 1, 2, 5, 3 };
            QuickSort.Sort(input);
            Assert.AreEqual(14, input.Count);

            var expected = new List<int> { 0, 1, 1, 2, 3, 3, 4, 5, 5, 5, 6, 7, 8, 9 };
            for (var i = 0; i < 14; i++)
            {
                Assert.AreEqual(expected[i], input[i]);
            }
        }
    }
}