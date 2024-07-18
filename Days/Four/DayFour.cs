using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundredDaysOfCsharp.Days.Four
{
    public class DayFour
    {
        public string ReverseParentheses(string s)
        {
            Stack<string> stack = new Stack<string>();
            StringBuilder current = new StringBuilder();

            foreach (char c in s)
            {
                if (c == '(')
                {
                    stack.Push(current.ToString());
                    current.Clear();
                }
                else if (c == ')')
                {
                    string reversed = Reverse(current.ToString());
                    current.Clear();
                    current.Append(stack.Pop()).Append(reversed);
                }
                else
                {
                    current.Append(c);
                }
            }

            return current.ToString();
        }
        private string Reverse(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
