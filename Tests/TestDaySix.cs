using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HundredDaysOfCsharp.Days.Five;
using HundredDaysOfCsharp.Days.Six;

namespace HundredDaysOfCsharp.Tests
{
    public class TestDaySix
    {

        DaySix d6 = new DaySix();
        private List<int> positions;
        private List<int> healths;
        private string directions = "RLRL";
        private IList<int> result;
        public void TestForDayFive()
        {
            // Test Case 1
            positions = new List<int>() { 5, 4, 3, 2, 1 };
            healths = new List<int>() { 2, 17, 9, 15, 10 };
            directions = "RRRRR";
            result = d6.SurvivedRobotsHealths(positions.ToArray(), healths.ToArray(), directions);
            Console.WriteLine($"Test Case 1 - Expected: [2,17,9,15,10], Answer: {result}");

            // Test Case 2
            positions = new List<int>() { 3, 5, 2, 6 };
            healths = new List<int>() { 10, 10, 15, 12 };
            directions = "RLRL";
            result = d6.SurvivedRobotsHealths(positions.ToArray(),healths.ToArray(), directions);
            Console.WriteLine($"Test Case 1 - Expected: [14], Answer: {result}");

            // Test Case 3
            positions = new List<int>() { 1, 2, 5, 6};
            healths = new List<int>() { 10, 10, 11, 11 };
            directions = "RLRL";
            result = d6.SurvivedRobotsHealths(positions.ToArray(), healths.ToArray(), directions);
            Console.WriteLine($"Test Case 1 - Expected: [], Answer: {result}");
        }
    }
}
