using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace advent_of_code.day01
{
    class Day01
    {
        private string filePath = @"C:\Users\PaulStephens\projects\advent-of-code\day01\input.txt";

        public int CountIncreases()
        {
            int lastLine = int.MaxValue;
            int increaseCount = 0;

            foreach (string line in File.ReadLines(filePath))
            {
                int currentLine = Int32.Parse(line);
                if (currentLine > lastLine)
                {
                    increaseCount++;
                }
                lastLine = currentLine;
            }

            return increaseCount;
        }

        public int CountSumIncreases()
        {
            int increaseCount = 0;
            int lastSum = int.MaxValue;
            List<int> inputs = new List<int>();

            foreach (string line in File.ReadLines(filePath))
            {
                inputs.Add(Int32.Parse(line));
            }

            for (int i = 0; i <= inputs.Count - 3; i++)
            {
                int sum = inputs.Skip(i).Take(3).Sum();
                if (sum > lastSum)
                {
                    increaseCount++;
                }
                lastSum = sum;
            }

            return increaseCount;
        }
    }
}
