using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    public class LengthOfLastWordSolution : ILeetCodeProblem
    {
        public void RunTests()
        {
            var result = LengthOfLastWord("a");
            Console.WriteLine(result);
        }

        public int LengthOfLastWord(string s)
        {
            int index = s.Length - 1;
            int length = 0;

            while(index >= 0 && s[index] == ' ')
            {
                index--;
            }

            while(index >= 0 && s[index] != ' ')
            {
                index--;
                length++;
            }

            return length;
        }
    }
}
