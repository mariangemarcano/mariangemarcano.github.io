using Xunit;

namespace Sort.Tests
{
    public class QuickSortTests
    {
        [Fact]
        public void Sort_Empty_Returs_Empty()
        {
            Assert.Equal(new int[0], new QuickSort().Sort(new int[0]));
        }

        [Fact]
        public void Sort_5_Items_Returns_Sorted_Items()
        {
            int[] unsorted = new int[] { 1, 5, 2, 4, 3 };
            int[] sorted = new int[] { 1, 2, 3, 4, 5 };
            var result = new QuickSort().Sort(unsorted);
            Assert.Equal(sorted, result);
        }

        [Fact]
        public void Sort_13_Items_Returns_Sorted_Items()
        {
            int[] unsorted = new int[] { 9, 4, 5, 4, 7, 10, 8, 2, 3, 1, 6, 5, 1 };
            int[] sorted = new int[] { 1, 1, 2, 3, 4, 4, 5, 5, 6, 7, 8, 9, 10 };
            Assert.Equal(sorted, new QuickSort().Sort(unsorted));
        }

    }
}
