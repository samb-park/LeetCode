using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    internal class FindTheIndexOfTheFirstOccurrenceInAString : ILeetCodeProblem
    {
        public void RunTests()
        {
            Console.WriteLine(StrStr("a", "a"));
        }

        public int StrStr(string haystack, string needle)
        {

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    int j = 1;
                    for (j = 1; j < needle.Length; j++)
                    {
                        if (haystack[i + j] != needle[j])
                            break;
                    }

                    if (needle.Length == j)
                        return i;
                }
            }

            return -1;
        }
    }
}
