using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace advent_of_code.day01
{
    class AdventOfCodeDay01
    {
        private List<int> ReadInputFromFile()
        {
            List<int> input = new List<int>();



            return input;
        }

        public int CountIncreases()
        {
            int lastLine = int.MaxValue;
            int increaseCount = 0;

            foreach (string line in System.IO.File.ReadLines(@"D:\Documents\Projects\advent-of-code\day01\input.txt"))
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
    }
}
