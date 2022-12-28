using System;
using System.Collections.Generic;
using System.Text;

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator

namespace CSharp8Demo
{
    public static class NullCoalescingAssignment
    {
        public static void Demo()
        {
            var example = new ListDemo();

            //if (example.LuckyNumbers == null)
            //{
            //    example.LuckyNumbers = new List<int>();
            //}

            // The null-coalescing operator ?? returns the value of its left-hand operand
            // if it isn't null; otherwise, it evaluates the right-hand operand and returns its result.
            example.LuckyNumbers ??= new List<int>();
            example.LuckyNumbers.Add(15);

            foreach (var item in example.LuckyNumbers)
            {
                Console.WriteLine($"Lucky Number: {item}");
            }
        }
    }

    public class ListDemo
    {
        public List<int> LuckyNumbers { get; set; }

        public ListDemo()
        {
            LuckyNumbers = new List<int>() { 21 };
        }
    }
}
