using RomanNumeralsConverters;
using System;

namespace RomanNumeralsConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanNumeralsConverterInputLoop();
        }

        private static void RomanNumeralsConverterInputLoop()
        { 
            bool quit = false;
            var converter = new ClassicRomanNumeralsConvert();
            DoMatrix(); //Make console look like the matrix
            while (!quit)
            {
                Console.WriteLine("Enter a number between 1 and 3999 (inclusive) or type quit to exit: ");
                string input = Console.ReadLine();
                if(input.ToLower() == "quit") //normalise input incase user tries to trick the exit criterea with "QuIt" or something similar..
                {
                    quit = true;
                    continue;
                }
                int value = ConvertInputToInt(input);
                if(value < 0)
                {
                    DisplayNag();
                    continue; //skip the rest and try again
                }
                var result = converter.generate(value);
                if(string.IsNullOrWhiteSpace(result))
                {
                    DisplayNag();

                }
                else Console.WriteLine(string.Concat(input, " in Roman Numerals is: ", result, ". Try another number"));
            }
        }

        private static void DisplayNag()
        {
            Console.WriteLine("Must be a whole, positive number between 1 and 3999. Try again...");
        }

        private static int ConvertInputToInt(string input)
        {
            var result = 0;
            var wasSuccess = Int32.TryParse(input, out result);

            return (wasSuccess || result < 0) ? result : -1; //-1 signifies an error or attempt to input negative numbers
        }

        private static void DoMatrix()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
