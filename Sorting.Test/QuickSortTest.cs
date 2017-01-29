using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sorting.Test
{
    [TestClass()]
    public class QuickSortTest
    {
        [TestMethod()]
        public void SortTest()
        {
            var quickSort = ISortFactory.GetSort(Sort.QuickSort);

            List<int> input = null;
            quickSort.Sort(input);
            Assert.IsNull(input);

            input = new List<int>();
            quickSort.Sort(input);
            Assert.AreEqual(0, input.Count);

            input = new List<int> { 5 };
            quickSort.Sort(input);
            Assert.AreEqual(1, input.Count);
            Assert.AreEqual(5, input[0]);

            input = new List<int> { 5, 4, 1, 8, 6, 7, 3, 5, 0, 9, 1, 2, 5, 3 };
            quickSort.Sort(input);
            Assert.AreEqual(14, input.Count);

            var expected = new List<int> { 0, 1, 1, 2, 3, 3, 4, 5, 5, 5, 6, 7, 8, 9 };
            for (var i = 0; i < 14; i++)
            {
                Assert.AreEqual(expected[i], input[i]);
            }
        }
    }
}