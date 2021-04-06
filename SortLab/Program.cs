using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;
using SortLab.Sorts;

namespace SortLab
{
    class Program
    {
        public static void Main()
        {
            // Чиение файла XML
            List<Experiment> experiments;
            using (var fileStream = new StreamReader(@"../../../experiments.xml"))
            {
                var root = new XmlRootAttribute("Experiments");
                var serializer = new XmlSerializer(typeof(List<Experiment>), root);
                experiments = (List<Experiment>)serializer.Deserialize(fileStream);
            }
            

            // Запуск экспериментов
            var stopWatch = new Stopwatch();
            var count = 0;
            foreach (var experiment in experiments)
            {
                Console.WriteLine($"Experiment: {count++} Length: {experiment.Length} Count: {experiment.Count}");

                experiment.GenetateStringArray();

                stopWatch.Restart();
                BubbleSort.Sort((string[])experiment.Arr.Clone());
                stopWatch.Stop();
                Console.WriteLine($"    BubbleSort - {stopWatch.ElapsedMilliseconds} мс");

                stopWatch.Restart();
                QuickSort.Sort((string[])experiment.Arr.Clone(), 0, experiment.Arr.Length - 1);
                stopWatch.Stop();
                Console.WriteLine($"    QuickSort - {stopWatch.ElapsedMilliseconds} мс");

                stopWatch.Restart();
                TreeSort.Sort((string[])experiment.Arr.Clone());
                stopWatch.Stop();
                Console.WriteLine($"    TreeSort - {stopWatch.ElapsedMilliseconds} мс");

                stopWatch.Restart();
                InsertionSort.Sort((string[])experiment.Arr.Clone());
                stopWatch.Stop();
                Console.WriteLine($"    InsertionSort - {stopWatch.ElapsedMilliseconds} мс");

                stopWatch.Restart();
                MergeSort.Sort((string[])experiment.Arr.Clone(), 0, experiment.Arr.Length);
                stopWatch.Stop();
                Console.WriteLine($"    MergeSort - {stopWatch.ElapsedMilliseconds} мс");

                stopWatch.Restart();
                HeapSort.Sort(experiment.Arr);
                stopWatch.Stop();
                Console.WriteLine($"    HeapSort - {stopWatch.ElapsedMilliseconds} мс");

                stopWatch.Restart();
                RadixSort.Sort((string[])experiment.Arr.Clone());
                stopWatch.Stop();
                Console.WriteLine($"    RadixSort - {stopWatch.ElapsedMilliseconds} мс");

                Console.WriteLine();
            }
        }
    }
}
