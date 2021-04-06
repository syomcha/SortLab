using System;

namespace SortLab
{
    [Serializable]
    public class Experiment
    {
        public int Length { get; set; }
        public int Count { get; set; }
        public string[] Arr { get; set; }

        public Experiment()
        {
        }

        public Experiment(int length, int count)
        {
            Length = length;
            Count = count;
        }

        public void GenetateStringArray()
        {
            var result = new string[Count];

            for (var i = 0; i < Count; i++)
            {
                var str = new char[Length];
                var r = new Random();

                for (int j = 0; j < r.Next(0, Length); j++)
                {
                    str[j] = (char)r.Next(97, 123);
                }

                result[i]  = new string(str);
            }

            Arr = result;
        }
    }
}