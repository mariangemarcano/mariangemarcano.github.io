using System;

namespace Sort
{
    public class BottomUpMergeSort : ISort
    {
        public int[] Sort(int[] array)
        {
            var length = array.Length;
            var sorted = new int[array.Length];

            for (int width = 1; width < length; width = 2 * width)
            {
                for (int leftIndex = 0; leftIndex < length; leftIndex = leftIndex + 2 * width)
                {
                    BottomUpMerge(array, leftIndex, Math.Min(leftIndex + width, length), Math.Min(leftIndex + 2 * width, length), sorted);
                }
                Array.Copy(sorted, array, length);
            }

            return array;

        }

        private void BottomUpMerge(int[] array, int leftIndex, int rightIndex, int lastIndex, int[] sorted)
        {
            var i = leftIndex;
            var j = rightIndex;

            for (int k = leftIndex; k < lastIndex; k++)
            {
                if (i < rightIndex && (j >= lastIndex || array[i] <= array[j]))
                {
                    sorted[k] = array[i];
                    i++;
                }
                else
                {
                    sorted[k] = array[j];
                    j++;
                }
            }
        }
    }
}
