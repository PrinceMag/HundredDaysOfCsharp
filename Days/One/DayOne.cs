using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundredDaysOfCsharp.Days.One
{
    public class DayTwo
    {
        public int MaxBottles(int numBottles, int numExchange)
        {
            int totalBottles = numBottles;

            while (numBottles >= numExchange)
            {
                totalBottles += numBottles / numExchange;
                numBottles = numBottles / numExchange + numBottles % numExchange;
            }

            return totalBottles;
        }
    }
}
