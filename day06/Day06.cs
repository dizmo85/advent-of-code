using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advent_of_code.day06
{
    internal class Day06
    {
        public Int64 Lanternfish(int dayCount)
        {
            string[] input = Utilities.ReadFileToArray(6);
            List<int> fishies = input[0].Split(',').Select(a => Convert.ToInt32(a)).ToList();
            Int64[] ageCount = new Int64[9];

            foreach (int i in fishies)
            {
                ageCount[i]++;
            }

            for (int day = 1; day <= dayCount; day++)
            {
                Int64 zero = ageCount[0];

                for (int i = 0; i < ageCount.Length - 1; i++)
                {
                    ageCount[i] = ageCount[i + 1];
                }

                ageCount[8] =zero;
                ageCount[6] += zero;
            }

            //Part 1 Logic
            //for (int day = 1; day <= dayCount; day++)
            //{
            //    List<int> newFish = new List<int>();
            //    for (int i = 0; i < fishies.Count; i++)
            //    {
            //        if (fishies[i] == 0)
            //        {
            //            newFish.Add(8);
            //            fishies[i] = 6;
            //        }
            //        else
            //        {
            //            fishies[i]--;
            //        }
            //    }

            //    fishies.AddRange(newFish);
            //}

            return ageCount.Sum();
        }
    }
}
