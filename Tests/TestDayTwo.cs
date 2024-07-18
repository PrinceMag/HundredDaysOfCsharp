using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HundredDaysOfCsharp.Days.Two;

namespace HundredDaysOfCsharp.Tests
{
    public class TestDayTwo
    {

        DayTwo d2 = new DayTwo();
        private int n;
        private int k;
        private int result;

        public void TestFoDayTwo() {
            // Test Case 1
            n = 5;
            k = 2;
            result = d2.FindTheWinner(n, k);
            Console.WriteLine($"Test Case 1 - Expected: 3, Answer: {result}");

            // Test Case 2
            n = 6;
            k = 5;
            result = d2.FindTheWinner(n, k);
            Console.WriteLine($"Test Case 2 - Expected: 1, Answer: {result}");
        }
    }
}
