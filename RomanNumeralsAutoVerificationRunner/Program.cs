using System;
using System.IO;
using System.Linq;
using RomanNumeralsConverters;

namespace RomanNumeralsAutoVerificationRunner
{
    class Program
    {
        //just a very quick main to see how the converter does with real sample data.
        static void Main(string[] args)
        {
            var numeralConversions = OpenFile();
            var correct = 0;
            foreach(var conversion in numeralConversions)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                var splitConversion = conversion.Split(',');
                var nnc = new NumberNumeralConversions(Int32.Parse(splitConversion[0]), splitConversion[1]);
                var crnc = new ClassicRomanNumeralsConvert();
                nnc.ActualResult = crnc.generate(nnc.Number);
                if (!nnc.WasCorrectResult)
                    Console.ForegroundColor = ConsoleColor.Red;
                else correct++;
                Console.WriteLine(nnc.ToString());
            }
            Console.WriteLine(correct + " out of " + numeralConversions.Count() + " correct");
            Console.WriteLine("Any key to exit..");
            Console.Read();
        }

        public static string[] OpenFile()
        {
            var fileContents = File.ReadAllLines("NumerNumeralConversions.csv");
            return fileContents;
        }
    }
}
