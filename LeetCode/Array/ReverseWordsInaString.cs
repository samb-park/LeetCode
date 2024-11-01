using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    internal class ReverseWordsInaString : ILeetCodeProblem
    {
        public void RunTests()
        {
            Console.WriteLine(ReverseWords("the sky is blue"));
        }

        public string ReverseWords(string s)
        {
            Stack<string> stack = new Stack<string>();
            StringBuilder sb = new StringBuilder();

            foreach(var c in s)
            {
                if (c != ' ')
                {
                    sb.Append(c);
                }
                else
                {
                    if (sb.Length > 0)
                    {
                        stack.Push(sb.ToString());
                        sb.Clear();
                    }
                }
            }

            if(sb.Length > 0)
            {
                stack.Push(sb.ToString());
            }

            sb.Clear();

            while(stack.Count > 0)
            {
                sb.Append(stack.Pop());

                if (stack.Count > 0)
                {
                    sb.Append(" ");
                }
            }

            return sb.ToString();
        }
    }
}
