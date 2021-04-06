namespace SortLab.Sorts
{
    public class BubbleSort
    {
        public static void Sort(string[] arr)
        {
            var len = arr.Length;
            for (var i = 0; i < len - 1; i++)
            {
                for (var j = 0; j < len - i - 1; j++)
                    if (string.Compare(arr[j], arr[j + 1]) > 0)
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1]; ;
                        arr[j + 1] = temp;
                    }
            }
        }
    }
}
