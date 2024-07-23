using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundredDaysOfCsharp.Days.Six
{
    public class DaySix
    {
        public IList<int> SurvivedRobotsHealths(int[] positions, int[] healths, string directions)
        {

            //ordering robots based on the position
            var robos = new SortedDictionary<int, int>();
            for (int i = 0; i < positions.Length; i++)
                robos.Add(positions[i], i);

            // used to hold the robots which moving on to right side
            var stack = new Stack<int>();

            foreach (int robo in robos.Values)
            {
                if (directions[robo] == 'R')
                    stack.Push(robo);
                // collision occurs between two robots
                // continuesly destroys the privious robots until this current robot destroy or all previous robots are destroy
                else
                {
                    while (stack.Count > 0)
                    {
                        // current robot destroy the previous robot and health of current robot is reduce
                        if (healths[stack.Peek()] < healths[robo])
                        {
                            healths[robo]--;
                            healths[stack.Pop()] = 0;
                        }
                        // both robots are destroy
                        else if (healths[stack.Peek()] == healths[robo])
                        {
                            healths[robo] = (healths[stack.Pop()] = 0);
                            break;
                        }
                        // previous robot destroy the current robot and health of previous robot is reduce
                        else
                        {
                            healths[stack.Peek()]--;
                            healths[robo] = 0;
                            break;
                        }
                    }
                }
            }

            // forming a list contains the health of robots which are not destroyed completely
            var list = new List<int>();
            foreach (int e in healths)
                if (e != 0)
                    list.Add(e);
            return list;
        }
    }
}