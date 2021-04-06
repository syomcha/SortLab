using NUnit.Framework;
using System;
using SortLab.Sorts;

namespace SortTests
{
    [TestFixture]
    class Test
    {
        [TestCase(10, 10)]
        [TestCase(10, 100)]
        [TestCase(100, 10)]
        [TestCase(100, 100)]
        public void BubbleSortTest(int length, int count)
        {
            var randomArr = GenetateStringArray(length, count);
            var expected = (string[])randomArr.Clone();

            Array.Sort(expected);
            BubbleSort.Sort(randomArr);

            Assert.AreEqual(expected, randomArr);
        }

        [TestCase(10, 10)]
        [TestCase(10, 100)]
        [TestCase(100, 10)]
        [TestCase(100, 100)]
        public void QuickSortTest(int length, int count)
        {
            var randomArr = GenetateStringArray(length, count);
            var expected = (string[])randomArr.Clone();

            Array.Sort(expected);
            QuickSort.Sort(randomArr, 0, randomArr.Length - 1);

            Assert.AreEqual(expected, randomArr);
        }


        [TestCase(10, 10)]
        [TestCase(10, 100)]
        [TestCase(100, 10)]
        [TestCase(100, 100)]
        public void TreeSortTest(int length, int count)
        {
            var randomArr = GenetateStringArray(length, count);
            var expected = (string[])randomArr.Clone();

            Array.Sort(expected);
            var actual = TreeSort.SortToArray(randomArr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 10)]
        [TestCase(10, 100)]
        [TestCase(100, 10)]
        [TestCase(100, 100)]
        public void InsertionSortTest(int length, int count)
        {
            var randomArr = GenetateStringArray(length, count);
            var expected = (string[])randomArr.Clone();

            Array.Sort(expected);
            InsertionSort.Sort(randomArr);

            Assert.AreEqual(expected, randomArr);
        }

        [TestCase(10, 10)]
        [TestCase(10, 100)]
        [TestCase(100, 10)]
        [TestCase(100, 100)]
        public void MergeSortTest(int length, int count)
        {
            var randomArr = GenetateStringArray(length, count);
            var expected = (string[])randomArr.Clone();

            Array.Sort(expected);
            MergeSort.Sort(randomArr, 0, randomArr.Length);

            Assert.AreEqual(expected, randomArr);
        }

        [TestCase(10, 10)]
        [TestCase(10, 100)]
        [TestCase(100, 10)]
        [TestCase(100, 100)]
        public void HeapSortTest(int length, int count)
        {
            var randomArr = GenetateStringArray(length, count);
            var expected = (string[])randomArr.Clone();

            Array.Sort(expected);
            HeapSort.Sort(randomArr);

            Assert.AreEqual(expected, randomArr);
        }

        [TestCase(10, 10)]
        [TestCase(10, 100)]
        [TestCase(100, 10)]
        [TestCase(100, 100)]
        public void RadixSortTest(int length, int count)
        {
            var randomArr = GenetateStringArray(length, count);
            var expected = (string[])randomArr.Clone();

            Array.Sort(expected);
            RadixSort.Sort(randomArr);

            Assert.AreEqual(expected, randomArr);
        }

        private static string[] GenetateStringArray(int length, int count)
        {
            var result = new string[count];

            for (var i = 0; i < count; i++)
            {
                var str = new char[length];
                var r = new Random();

                for (int j = 0; j < r.Next(0, length); j++)
                {
                    str[j] = (char)r.Next(97, 123);
                }

                result[i] = new string(str);
            }

            return result;
        }
    }
}
