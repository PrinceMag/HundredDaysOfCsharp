using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HundredDaysOfCsharp.Days.One;

namespace HundredDaysOfCsharp.Tests
{
    public class TestDayOne
    {

        DayOne d1 = new DayOne();
        private int numBottles;
        private int numExchange;
        private int result;

        public void TestFoDayOne() {
            // Test Case 1
            numBottles = 9;
            numExchange = 3;
            result = d1.MaxBottles(numBottles, numExchange);
            Console.WriteLine($"Test Case 1 - Expected: 13, Answer: {result}");

            // Test Case 2
            numBottles = 15;
            numExchange = 4;
            result = d1.MaxBottles(numBottles, numExchange);
            Console.WriteLine($"Test Case 2 - Expected: 19, Answer: {result}");
        }
    }
}
