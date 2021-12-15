using System;
using System.Collections.Generic;
using System.Linq;
using advent_of_code;

namespace advent_of_code.day05
{
    class Day05
    {
        public int HydrothermalVenture()
        {
            string[] input = Utilities.ReadFileToArray(5);
            Dictionary<string, int> ventPoints = new Dictionary<string, int>();

            foreach (string line in input)
            {
                // get each set of coordinates
                string[] coordinates = line.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                int[] start = coordinates[0].Split(',').Select(x => Convert.ToInt32(x)).ToArray();
                int[] end = coordinates[1].Split(',').Select(y => Convert.ToInt32(y)).ToArray(); ;


                //generate the points on the line between start and end
                //IEnumerable<int> x_line = Enumerable.Range(start[0] <= end[0] ? start[0] : end[0], Math.Abs(end[0] - start[0]) + 1);
                //IEnumerable<int> y_line = Enumerable.Range(start[1] <= end[1] ? start[1] : end[1], Math.Abs(end[1] - start[1]) + 1);

                List<int[]> lineSeg = new List<int[]>() { new int[] { start[0] <= end[0] ? start[0] : end[0], start[1] <= end[1] ? start[1] : end[1] } };

                List<int> x_line = new List<int>() { 1 };
                List<int> y_line = new List<int>() { 1 };
                for (int i = 1; i <= Math.Abs(end[0] - start[0]); i++)
                {
                    int[] point = new int[] { lineSeg[0][0], lineSeg[0][1] };

                    if (start[0] != end[0])
                        point[0] += i;
                    //x_line.Add(Convert.ToInt32(start[0] <= end[0] ? start[0] : end[0]) + i);

                    if (start[1] != end[1])
                        point[1] += i;
                    //y_line.Add(Convert.ToInt32(start[1] <= end[1] ? start[1] : end[1]) + i);
                    lineSeg.Add(point);
                }

                foreach (int[] i in lineSeg)
                {   
                    string point = string.Format("{0},{1}", i[0], i[1]);

                    if (!ventPoints.ContainsKey(point))
                        ventPoints.Add(point, 1);
                    else
                        ventPoints[point]++;
                }
            }

            return ventPoints.Where(p => p.Value > 1).Count();
        }
    }
}
