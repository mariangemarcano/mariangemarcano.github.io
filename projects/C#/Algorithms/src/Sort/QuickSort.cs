using System;
using System.Collections.Generic;

namespace Sort
{
    public class QuickSort : ISort
    {
        public int[] Sort(int[] array)
        {
            int[] sorted = QSort(array, 0, array.Length - 1);
            return array;
        }

        private int[] QSort(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                int partionIndex = Partition(array, lowIndex, highIndex);
                QSort(array, lowIndex, partionIndex - 1);
                QSort(array, partionIndex + 1, highIndex);
            }
            return array;
        }

        private int Partition(int[] array, int lowIndex, int highIndex)
        {
            int pivot = array[highIndex];
            int partitionIndex = lowIndex;

            for (int j = partitionIndex; j < highIndex; j++)
            {
                if (array[j] < pivot)
                {
                    Swap(array, partitionIndex, j);
                    partitionIndex++;
                }
            }
            Swap(array, partitionIndex, highIndex);
            return partitionIndex;
        }

        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
