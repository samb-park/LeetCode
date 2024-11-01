using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    internal class LongestCommonPrefixSolution : ILeetCodeProblem
    {
        public void RunTests()
        {
            throw new NotImplementedException();
        }

        public string LongestCommonPrefix(string[] strs)
        {
            var prefix = strs[0];

            for(int i = 1; i < strs.Length; i++)
            {
                var minLength = Math.Min(prefix.Length, strs[i].Length);
                var temp = new StringBuilder();


                for (int j = 0; j < minLength; j++)
                {
                    if (strs[i][j] == prefix[j])
                    {
                        temp.Append(prefix[j]);
                    }
                    else
                    {
                        break;
                    }
                }

                prefix = temp.ToString();
            }

            return prefix;
            
        }
    }
}
