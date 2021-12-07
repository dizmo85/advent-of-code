using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using advent_of_code.day01;

namespace advent_of_code
{
    class Program
    {
        static void Main(string[] args)
        {
            AdventOfCodeDay01 day01 = new AdventOfCodeDay01();
            int count = day01.CountIncreases();
            System.Console.WriteLine(count);
            System.Console.Read();
        }
    }
}
