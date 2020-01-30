using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CsvParser
{
    class Program
    {
        static void Main(string[] args)
        {

            var stream = typeof(Program).GetTypeInfo().Assembly.GetManifestResourceStream("CsvParser.Marvel.csv"); 
            var reader = new StreamReader(stream);
            var CsvReader = new CsvReader(reader);
            foreach (var line in CsvReader.Lines)
                Console.WriteLine (
                    line.First(p => p.Key == "Title").Value
                );
        }
    }
}
