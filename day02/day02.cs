using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace advent_of_code.day02
{
    class Day02
    {
        private string filePath = @"C:\Users\PaulStephens\projects\advent-of-code\day02\input.txt";

        public int FinalDestination()
        {
            int[] position = new int[2] { 0, 0 };

            foreach (string line in File.ReadLines(filePath))
            {
                string[] directions = line.Split('\u0020');

                switch (directions[0])
                {
                    case "forward":
                        position[0] += Convert.ToInt32(directions[1]);
                        break;
                    case "down":
                        position[1] += Convert.ToInt32(directions[1]);
                        break;
                    case "up":
                        position[1] -= Convert.ToInt32(directions[1]);
                        break;
                    default:
                        break;
                }
            }

            return position[0] * position[1];
        }

        public int FinalFinalDestination()
        {
            int[] position = new int[2] { 0, 0 };
            int aim = 0;

            foreach (string line in File.ReadLines(filePath))
            {
                string[] directions = line.Split('\u0020');

                switch (directions[0])
                {
                    case "forward":
                        int forward = Convert.ToInt32(directions[1]);
                        position[0] += forward;
                        position[1] += aim * forward;
                        break;
                    case "down":
                        aim += Convert.ToInt32(directions[1]);
                        break;
                    case "up":
                        aim -= Convert.ToInt32(directions[1]);
                        break;
                    default:
                        break;
                }
            }

            return position[0] * position[1];
        }
    }
}
