using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HundredDaysOfCsharp.Days.Four;

namespace HundredDaysOfCsharp.Tests
{
    public class TestDayFour
    {

        DayFour d4 = new DayFour();
        private string s;
        private string result;
        public void TestForDayFour() {
            // Test Case 1
            s = "(abcd)";
            result = d4.ReverseParentheses(s);
            Console.WriteLine($"Test Case 1 - Expected: \"dcba\", Answer: {result}");

            // Test Case 2
            s = "(u(love)i)";
            result = d4.ReverseParentheses(s);
            Console.WriteLine($"Test Case 2 - Expected: \"iloveu\", Answer: {result}");

            // Test Case 2
            s = "(ed(et(oc))el)";
            result = d4.ReverseParentheses(s);
            Console.WriteLine($"Test Case 2 - Expected: \"leetcode\", Answer: {result}");
        }
    }
}
