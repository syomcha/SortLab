namespace SortLab.Sorts
{
    public class InsertionSort
    {
        public static void Sort(string[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                int j = i - 1;
                var key = arr[i];

                while (j >= 0 && string.Compare(arr[j], key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j -= 1;
                }

                arr[j + 1] = key;
            }    
        }
    }
}
