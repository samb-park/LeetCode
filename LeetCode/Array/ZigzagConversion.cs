using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    internal class ZigzagConversion : ILeetCodeProblem
    {
        public void RunTests()
        {
            var Converted = Convert("AB", 1);
            Console.WriteLine(Converted);
        }
        public string Convert(string s, int numRows)
        {
            List<StringBuilder> outputs = new List<StringBuilder>();
            int currentIndex = 0;
            bool isGoingDown = true;


            for (int i = 0; i < numRows; i++)
            {
                outputs.Add(new StringBuilder());
            }

            foreach (var c in s)
            {
                if(numRows == 1)
                    currentIndex = 0;

                outputs[currentIndex].Append(c);

                if (isGoingDown && currentIndex == numRows - 1)
                {
                    isGoingDown = false;
                }
                else if (!isGoingDown && currentIndex == 0)
                {
                    isGoingDown = true;
                }

                if (isGoingDown)
                {
                    currentIndex++;
                }
                else
                {
                    currentIndex--;
                }
            }

            var result = "";

            foreach (var output in outputs)
            {
                result += output.ToString();
            }
            return result;
        }
    }
}
