using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace advent_of_code_2022.Utility
{
    public static class AOCInputDataReader
    {

        // Utility tool to read out the input provided by advent of code site
        public static IEnumerable<string> ReadInput(string fileName)
        {
            string resourceName = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\Data\\" + fileName;
            var lines = File.ReadLines(resourceName);
            return lines;
        }

    }
}