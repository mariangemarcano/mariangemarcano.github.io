namespace Sort
{
    public class BubbleSort : ISort
    {
        public int[] Sort(int[] array)
        {
            var swap = true;
            while (swap)
            {
                swap = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swap = true;
                    }
                }
            }
            return array;
        }
    }
}
