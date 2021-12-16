using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using advent_of_code.day01;
using advent_of_code.day02;
using advent_of_code;

namespace advent_of_code
{
    class Program
    {
        static void Main(string[] args)
        {
            RunDay06();
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
            int output = day02.FinalFinalDestination();

            System.Console.WriteLine(output);
            System.Console.ReadLine();
        }

        static void RunDay03()
        {
            day03.Day03 day03 = new day03.Day03();
            int output = day03.BinaryDiagnostic();
            int rating = day03.LifeSupportRating();

            System.Console.WriteLine(output);
            System.Console.WriteLine(rating);
            System.Console.ReadLine();
        }

        static void RunDay04()
        {
            day04.Day04 day04 = new day04.Day04();
            int score = day04.SquidBingo();
            int lastScore = day04.LastToWin();

            System.Console.WriteLine(score);
            System.Console.WriteLine(lastScore);
            System.Console.ReadLine();
        }

        static void RunDay05()
        {
            day05.Day05 day05 = new day05.Day05();
            int overlapCount = day05.HydrothermalVenture();

            System.Console.WriteLine(overlapCount);
            System.Console.ReadLine();
        }

        static void RunDay06()
        {
            day06.Day06 day06 = new day06.Day06();
            Int64 lanternfishCount = day06.Lanternfish(256);

            System.Console.WriteLine(lanternfishCount);
            System.Console.ReadLine();
        }
    }
}
