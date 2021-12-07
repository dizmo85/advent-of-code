using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using advent_of_code.day01;
using advent_of_code.day02;

namespace advent_of_code
{
    class Program
    {
        static void Main(string[] args)
        {
            RunDay02();
        }

        static void RunDay01()
        {
            Day01 day01 = new Day01();
            int output = day01.CountSumIncreases();

            System.Console.WriteLine(output);
            System.Console.ReadLine();
        }

        static void RunDay02()
        {
            Day02 day02 = new Day02();
            int output = day02.FinalDestination();

            System.Console.WriteLine(output);
            System.Console.ReadLine();
        }
    }
}
