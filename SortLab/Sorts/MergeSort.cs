namespace SortLab.Sorts
{
    public class MergeSort
    {
        public static void Sort(string[] strList, int left, int right)
        {

            if (left + 1 >= right)
                return;

            var mid = (left + right) / 2;

            Sort(strList, left, mid);
            Sort(strList, mid, right);

            Merge(strList, left, mid, right);
        }

        private static string[] Merge(string[] arr, int left, int mid, int right)
        {
            var a = 0;
            var b = 0;
            var result = new string[right - left]; 

            while (left + a < mid && mid + b < right)
            {
                if (string.Compare(arr[left + a], arr[mid + b]) < 0)
                {
                    result[a + b] = arr[left + a];
                    a++;
                }
                else
                {
                    result[a + b] = arr[mid + b];
                    b++;
                }
            }

            while (left + a < mid)
            {
                result[a + b] = arr[left + a];
                a++;
            }


            while (mid + b < right)
            {
                result[a + b] = arr[mid + b];
                b++;
            }

            for (var i = 0; i < a + b; i++)
                arr[left + i] = result[i];

            return result;
        }
    }
}
