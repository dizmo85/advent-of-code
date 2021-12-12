using System;
using System.Collections.Generic;
using System.IO;

namespace advent_of_code
{
    internal class Utilities
    {
        static public string[] ReadFileToArray(int day)
        {
            string filePath = String.Format(@"..\..\day{0:D2}\input.txt", day);
            return File.ReadAllLines(filePath);
        }
    }
}
