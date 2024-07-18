using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HundredDaysOfCsharp.Days.Three;

namespace HundredDaysOfCsharp.Tests
{
    public class TestDayThree
    {

        DayThree d3 = new DayThree();
        private int n;
        private int k;
        private int result;
        List<string> logs;
        public void TestFoDayThree() {
            // Test Case 1
            logs = new List<string>() { "d1/", "d2/", "../", "d21/", "./" };
            result = d3.MinOperations(logs.ToArray());
            Console.WriteLine($"Test Case 1 - Expected: 2, Answer: {result}");

            // Test Case 2
            logs = new List<string>() { "d1/", "d2/", "./", "d3/", "../", "d31/" };
            result = d3.MinOperations(logs.ToArray());
            Console.WriteLine($"Test Case 2 - Expected: 3, Answer: {result}");

            // Test Case 2
            logs = new List<string>() { "d1/", "../", "../", "../" };
            result = d3.MinOperations(logs.ToArray());
            Console.WriteLine($"Test Case 2 - Expected: 0, Answer: {result}");
        }
    }
}
