using System;
using System.Collections.Generic;
using TextService.DTO;

namespace TextService
{
    public class MyService : IMyService
    {
        public string GetData() => "My service string";

        public string GetMessage(string Name) => $"Hello Mr/Ms {Name}";

        public string GetResult(Student student)
        {
            var avg = (student.M1 + student.M2 + student.M3) / 3.0;
            return $"{student.StudentName} {(avg >= 35.0 ? "passes" : "fails")}";
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

        public Student GetTopper(IEnumerable<Student> students)
        {
            var topper = new Student();
            var topResult = 0;
            foreach(var student in students)
            {
                var result = student.M1 + student.M2 + student.M3;
                if (result > topResult)
                {
                    topResult = result;
                    topper = student;
                }
            }
            return topper;
        }
    }
}
