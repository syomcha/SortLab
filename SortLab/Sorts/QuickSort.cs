namespace SortLab.Sorts
{
    public class QuickSort
    {
        public static void Sort(string[] arr, int left, int right)
        {
            int i = left, j = right;
            var v = arr[(left + right) / 2];

            while (i <= j)
            {
                while (string.Compare(arr[i], v) < 0)
                    i++;

                while (string.Compare(arr[j], v) > 0)
                    j--;

                if (i <= j)
                {
                    if (string.Compare(arr[i], arr[j]) > 0)
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                    i++;
                    j--;
                }
            }

            if (left < j)
                Sort(arr, left, j);

            if (i < right)
                Sort(arr, i, right);
        }
    }
}
