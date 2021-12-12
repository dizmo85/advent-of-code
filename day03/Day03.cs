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

            foreach (string line in input)
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

            for (int i = 0; i < bitCount.Length; i++)
            {
                bitCount[i] = bitCount[i] == 1 ? 0 : 1;
            }

            int epsilon = Convert.ToInt32(String.Join("", bitCount), 2);

            return gamma * epsilon;
        }

        public int LifeSupportRating()
        {
            string[] input = Utilities.ReadFileToArray(3);

            int o2GenRating = Convert.ToInt32(String.Join("", O2GeneratorRating(input.ToList(), 0)), 2);
            int co2ScrubberRating = Convert.ToInt32(String.Join("", CO2ScrubberRating(input.ToList(), 0)), 2);

            return o2GenRating * co2ScrubberRating;
        }

        private char MostCommonBit(List<string> binaryNumbers, int position)
        {
            int count0 = 0;
            int count1 = 0;

            foreach (string number in binaryNumbers)
            {
                if (number[position] == '0')
                    count0++;
                else
                    count1++;
            }

            char mostCommonBit = count0 > count1 ? '0' : '1';
            return mostCommonBit;
        }

        private string O2GeneratorRating(List<string> binaryNumbers, int position)
        {
            char mostCommonBit = MostCommonBit(binaryNumbers, position);
            List<string> resultString = binaryNumbers.Where(number => number[position] == mostCommonBit).ToList();

            if (resultString.Count == 1)
                return resultString[0];
            else
                return O2GeneratorRating(resultString, ++position);
        }

        private string CO2ScrubberRating(List<string> binaryNumbers, int position)
        {
            char leastCommonBit = MostCommonBit(binaryNumbers, position) == '1' ? '0' : '1';
            List<string> resultString = binaryNumbers.Where(number => number[position] == leastCommonBit).ToList();

            if (resultString.Count == 1)
                return resultString[0];
            else
                return CO2ScrubberRating(resultString, ++position);
        }
    }
}
