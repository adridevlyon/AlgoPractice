using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinarySearchTree.Test
{
    [TestClass()]
    public class TreeTest
    {
        [TestMethod()]
        public void SimpleTreesAreNotEqual()
        {
            Assert.AreNotEqual(new Tree(5), null);
            Assert.AreNotEqual(null, new Tree(5));
            Assert.AreNotEqual(new Tree(5), new Tree(4));
        }

        [TestMethod]
        public void ComplexTreesAreNotEqual()
        {
            Assert.AreNotEqual(new Tree(4) { Left = new Tree(3) }, new Tree(4));

            Assert.AreNotEqual(new Tree(4), new Tree(4) { Left = new Tree(3) });

            Assert.AreNotEqual(new Tree(4) { Right = new Tree(3) }, new Tree(4));

            Assert.AreNotEqual(new Tree(4), new Tree(4) { Right = new Tree(3) });

            Assert.AreNotEqual(new Tree(4)
            {
                Right = new Tree(3),
                Left = new Tree(2)
            },
            new Tree(4)
            {
                Right = new Tree(3),
                Left = new Tree(5)
            });

            Assert.AreNotEqual(new Tree(4)
            {
                Right = new Tree(3),
                Left = new Tree(2)
            },
            new Tree(4)
            {
                Right = new Tree(4),
                Left = new Tree(2)
            });
        }

        [TestMethod()]
        public void SimpleTreesAreEqual()
        {
            Assert.AreEqual(new Tree(4), new Tree(4));
        }

        [TestMethod()]
        public void TreesWithLeftOnlySimpleAreEqual()
        {
            Assert.AreEqual(new Tree(4) { Left = new Tree(7) }, new Tree(4) { Left = new Tree(7) });
        }

        [TestMethod()]
        public void TreesWithRightOnlySimpleAreEqual()
        {
            Assert.AreEqual(new Tree(4) { Right = new Tree(7) }, new Tree(4) { Right = new Tree(7) });
        }

        [TestMethod()]
        public void TreesWithBothSimpleAreEqual()
        {
            Assert.AreEqual(new Tree(4)
            {
                Left = new Tree(6),
                Right = new Tree(7)
            },
            new Tree(4)
            {
                Left = new Tree(6),
                Right = new Tree(7)
            });
        }

        [TestMethod()]
        public void TreesWithBothNotSimpleAreEqual()
        {
            Assert.AreEqual(new Tree(4)
            {
                Left = new Tree(6) { Right = new Tree(9) },
                Right = new Tree(7)
                {
                    Left = new Tree(8),
                    Right = new Tree(9)
                }
            },
            new Tree(4)
            {
                Left = new Tree(6) { Right = new Tree(9) },
                Right = new Tree(7)
                {
                    Left = new Tree(8),
                    Right = new Tree(9)
                }
            });
        }

        [TestMethod()]
        public void TreesHaveSameHashCode()
        {
            Assert.AreEqual(
                4.GetHashCode()
                + 6.GetHashCode()
                + 9.GetHashCode()
                + 7.GetHashCode()
                + 8.GetHashCode()
                + 9.GetHashCode()
                , new Tree(4)
                {
                    Left = new Tree(6) { Right = new Tree(9) },
                    Right = new Tree(7)
                    {
                        Left = new Tree(8),
                        Right = new Tree(9)
                    }
                }.GetHashCode()
            );
        }
    }
}