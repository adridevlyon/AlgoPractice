using System;
using System.Collections.Generic;
using Sorting;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        public static Tree CreateBinarySearchTree(List<int> input, bool isInputOrdered = false)
        {
            var length = input?.Count ?? 0;
            if (length == 0) return null;

            if (length == 1) return new Tree(input[0]);

            if (!isInputOrdered)
            {
                var quickSort = ISortFactory.GetSort(Sort.QuickSort);
                quickSort.Sort(input);
            }

            var halfLength = length / 2;
            var inputLeft = input.GetRange(0, halfLength);
            var inputRight = input.GetRange(halfLength + 1, (Math.Min(halfLength, length - 1 - halfLength)));

            return new Tree(input[halfLength])
            {
                Left = CreateBinarySearchTree(inputLeft, true),
                Right = CreateBinarySearchTree(inputRight, true)
            };
        }
    }
}