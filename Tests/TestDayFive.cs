using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HundredDaysOfCsharp.Days.Five;

namespace HundredDaysOfCsharp.Tests
{
    public class TestDayFive
    {

        DayFive d5 = new DayFive();
        private string? s;
        private int x = 0;
        private int y = 0;
        private int result;
        public void TestForDayFive() {
            // Test Case 1
            s = "cdbcbbaaabab";
            x = 4;
            y = 5;
            result = d5.MaximumGain(s,x,y);
            Console.WriteLine($"Test Case 1 - Expected: 19, Answer: {result}");

            // Test Case 2
            s = "aabbaaxybbaabb";
            x = 5;
            y = 4;
            result = d5.MaximumGain(s, x, y);
            Console.WriteLine($"Test Case 2 - Expected: 20, Answer: {result}");
        }
    }
}
