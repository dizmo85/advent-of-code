using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using advent_of_code;

namespace advent_of_code.day03
{
    internal class Day03
    {
        public int BinaryDiagnostic()
        {
            string[] input = Utilities.ReadFileToArray(3);
            int[] bitCount = new int[input[0].Length];

            foreach (string line in Utilities.ReadFileToArray(3))
            {
                for (int i = 0; i < bitCount.Length; i++)
                {
                    if (line[i] == '1')
                        bitCount[i]++;
                    else
                        bitCount[i]--;
                }
            }

            for (int i = 0; i < bitCount.Length; i++)
            {
                bitCount[i] = bitCount[i] > 0 ? 1 : 0;
            }

            int gamma = Convert.ToInt32(String.Join("", bitCount), 2);
            
            for (int i=0; i < bitCount.Length;i++)
            {
                bitCount[i] = bitCount[i] == 1 ? 0 : 1;
            }

            int epsilon = Convert.ToInt32(String.Join("", bitCount), 2);

            return gamma * epsilon;
        }
    }
}
