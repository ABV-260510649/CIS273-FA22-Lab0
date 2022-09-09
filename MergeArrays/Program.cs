using System.Collections.Immutable;

namespace MergeArrays
{

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 2, 3, 4, 5 };
            int[] array2 = new int[] { 3,2,5,4,6  };
            MergeSortedArrays(array1,array2);
            
        }

        public static int[] MergeSortedArrays(int[] array1, int[] array2)
        {
            int[] sorted_array = new int[array1.Length + array2.Length];
            array1.CopyTo(sorted_array, 0);
            array2.CopyTo(sorted_array, array1.Length);
            Array.Sort(sorted_array);
            return sorted_array;
        }
    }

}