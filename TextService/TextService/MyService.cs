using System;
using System.Threading;

namespace TextService
{
    public class MyService : IMyService
    {
        public string GetData() => "My service string";

        public string GetMessage(string Name) => $"Hello Mr/Ms {Name}";

        public string GetResult(int Sid, string SName, int M1, int M2, int M3)
        {
            var avg = (M1 + M2 + M3) / 3.0;
            return avg >= 35.0 ? "Pass" : "Fail";
        }

        public int GetMax(int[] arr)
        {
            var max = arr[0];
            foreach(var x in arr)
                max = x > max ? x : max;
            return max;
        }

        public int[] GetSorted(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }
    }
}
