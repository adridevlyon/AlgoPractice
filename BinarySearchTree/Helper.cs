using System.Collections.Generic;

namespace BinarySearchTree
{
    public static class Helper
    {
        public static void Sort(List<int> input, int start = 0, int end = -1)
        {
            var length = input?.Count ?? 0;
            if (length <= 1) return;

            if (end == -1)
            {
                end = length;
            }

            if (end - start <= 1) return;

            var pivotIndex = start;
            var pivot = input[pivotIndex];
            for (var i = start + 1; i < end; i++)
            {
                var val = input[pivotIndex + 1];
                input.RemoveAt(pivotIndex + 1);
                if (val < pivot)
                {
                    input.Insert(start, val);
                    pivotIndex++;
                }
                else
                {
                    input.Insert(end - 1, val);
                }
            }
            Sort(input, 0, pivotIndex);
            Sort(input, pivotIndex + 1, end);
        }
    }
}
