using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    public class IntegerToRomanSolution : ILeetCodeProblem
    {
        public void RunTests()
        {
            var result = IntToRoman(3749);

            Console.WriteLine(result);
        }

        public string IntToRoman(int num)
        {
            int[] values = new int[] {
                1000,
                900,
                500,
                400, 
                100, 
                90,
                50,
                40,
                10,
                9, 
                5,
                4,
                1};

            string[] symbols = new string[] {
                "M",
                "CM","D","CD","C",
                "XC","L","XL","X",
                "IX","V","IV","I"
            };

            StringBuilder roman = new StringBuilder();
            var current = 0;
            
            while ( num != 0 )
            {
                if(num >= values[current])
                {
                    num -= values[current];
                    roman.Append(symbols[current]);
                }
                else
                {
                    current++;
                }
            }

            return roman.ToString();
        }
    }
}
