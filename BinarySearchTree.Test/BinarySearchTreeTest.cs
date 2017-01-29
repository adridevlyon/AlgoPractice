using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinarySearchTree.Test
{
    [TestClass()]
    public class BinarySearchTreeTest
    {
        [TestMethod]
        public void CreateNullBinarySearchTree()
        {
            Assert.IsNull(BinarySearchTree.CreateBinarySearchTree(null));
            Assert.IsNull(BinarySearchTree.CreateBinarySearchTree(new List<int>()));
        }

        [TestMethod]
        public void CreateSimpleBinarySearchTree()
        {
            Assert.AreEqual(new Tree(5), BinarySearchTree.CreateBinarySearchTree(new List<int> { 5 }));
            Assert.AreEqual(new Tree(5), BinarySearchTree.CreateBinarySearchTree(new List<int> { 5 }, true));
        }

        [TestMethod()]
        public void CreateBinarySearchTreeOrderedTest()
        {
            var input = new List<int> { 1, 2, 3, 5, 7, 9 };

            var expectedBST = new Tree(5)
            {
                Left = new Tree(2)
                {
                    Left = new Tree(1),
                    Right = new Tree(3)
                },
                Right = new Tree(9)
                {
                    Left = new Tree(7)
                }
            };

            Assert.AreEqual(expectedBST, BinarySearchTree.CreateBinarySearchTree(input, true));
        }

        [TestMethod()]
        public void CreateBinarySearchTreeNotOrderedTest()
        {
            var input = new List<int> { 9, 3, 2, 5, 7, 1 };

            var expectedBST = new Tree(5)
            {
                Left = new Tree(2)
                {
                    Left = new Tree(1),
                    Right = new Tree(3)
                },
                Right = new Tree(9)
                {
                    Left = new Tree(7)
                }
            };

            Assert.AreEqual(expectedBST, BinarySearchTree.CreateBinarySearchTree(input));
        }
    }
}