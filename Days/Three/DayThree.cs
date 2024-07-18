using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundredDaysOfCsharp.Days.Three
{
    public class DayThree
    {
        public int MinOperations(string[] logs)
        {
            List<string> args = new List<string>();
            string oneBack = "../";
            string sameDirectory = "./";

            // Filter logs that contain a dot and add them to args
            logs.Where(log => log.Contains('.')).ToList().ForEach(log => args.Add(log));

            // Directory stack to simulate directory navigation
            Stack<string> directory = new Stack<string>();

            foreach (var path in logs)
            {
                if (args.Contains(path))
                {
                    if (path == oneBack)
                    {
                        if (directory.Count > 0)
                        {
                            directory.Pop(); // Go back to the parent directory
                        }
                    }
                }
                else if (path != sameDirectory)
                {
                    directory.Push(path); // Add the current directory
                }
            }

            // Return the count of directories in the stack
            return directory.Count;
        }
    }
}
