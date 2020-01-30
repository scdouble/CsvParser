﻿using System;

using System.IO;
using System.Linq;

namespace CsvParser
{
    class Program
    {
        static void Main(string[] args)
        {

            var reader = new StreamReader(new FileStream("Marvel.csv", FileMode.Open));
            var CsvReader = new CsvReader(reader);
            foreach (var line in CsvReader.Lines)
                Console.WriteLine (
                    line.First(p => p.Key == "Title").Value
                );
        }
    }
}
