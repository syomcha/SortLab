namespace SortLab.Sorts
{
    public class HeapSort
    {
        private static void Heapify(string[] arr, int n, int i)
        {
            var max = i;
            var left = 2 * i + 1;
            var right = 2 * i + 2;

            if (left < n && string.Compare(arr[left], arr[max]) > 0)
                max = left;

            if (right < n && string.Compare(arr[right], arr[max]) > 0)
                max = right;

            if (max != i)
            {
                var temp = arr[i];
                arr[i] = arr[max];
                arr[max] = temp;

                Heapify(arr, n, max);
            }
        }

        // O(n log n)
        public static void Sort(string[] arr) 
        {
            var n = arr.Length;

            for (var i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

            for (var i = n - 1; i > 0; i--)
            {

                var temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                Heapify(arr, i, 0);
            }
        }
    }
}
