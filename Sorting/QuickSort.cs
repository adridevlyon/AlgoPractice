using System.Collections.Generic;

namespace Sorting
{
    public class QuickSort : ISort
    {
        public void Sort(List<int> input)
        {
            var length = input?.Count ?? 0;
            if (length <= 1) return;

            Sort(input, 0, length);
        }


        private void Sort(List<int> input, int start, int end)
        {
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
