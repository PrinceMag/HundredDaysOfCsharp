using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundredDaysOfCsharp.Days.Two
{
    public class DayTwo
    {
        public int FindTheWinner(int n, int k)
        {
            var peopleList = new List<int>(Enumerable.Range(1, n));

            int currentIndex = 0;
            while (peopleList.Count > 1)
            {
                currentIndex = (currentIndex + k - 1) % peopleList.Count;
                peopleList.RemoveAt(currentIndex);
            }

            return peopleList[0];
        }
    }
}
