using RomanNumeralsConverters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralsConverters
{
    public class ClassicRomanNumeralsConvert : RomanNumeralGenerator
    {
        private List<NumeralSet> _Numerals;

        public ClassicRomanNumeralsConvert()
        {
            _Numerals = new List<NumeralSet>
            {
                new NumeralSet('I','V', 'X'),
                new NumeralSet('X', 'L', 'C'),
                new NumeralSet('C', 'D', 'M'),
                new NumeralSet('M', '-', '-')
            };
        }

        public string generate(int value)
        {
            if (!ValidateInput(value)) return string.Empty; // ensure no incorrect input, as per the brief
            var valueAsPlaceValues = value.ToString().ToList();
            //The approach here was to split the input in to its place holder values.
            //H|T|U
            //1 0 3
            valueAsPlaceValues.Reverse();
            //the ToList function gave me the plave holder values in the wrong order, so reverse.
            string runningRomanTotal = string.Empty;
            //store the value with each pass
            for (int i = 0; i < valueAsPlaceValues.Count; i++)
            {
                //iterate through each place holder
                int placeHolderValue = Int32.Parse(valueAsPlaceValues[i].ToString());
                //cast the place holder value back to a numer for easy of use in the next class
                var currentPlaceholdersNumerals = _Numerals[i];
                //get the numerals that represent the current place holder. place holder 0 represents units, 1 is tens and so on.
                //remember that each place holder is concerned with 3 different characters. low bound, say I, upper bound V and the lower numeral for the next place holder, X
                //this allows support for n before y - IV (one before 5) for 4, for example
                NumeralsPlaceHolder numeralPlaceHolder = GetNewNumeralsPlaceHolder(currentPlaceholdersNumerals);
                //create instance, passing in the symbols of concern to the current placeholder
                var numeralResult = numeralPlaceHolder.generate(placeHolderValue); // see generate function for description
                //and generate.
                runningRomanTotal = numeralResult + runningRomanTotal;
                //add result to running result and do it all again! (if necessary)
            }
            return runningRomanTotal;
        }

        private static NumeralsPlaceHolder GetNewNumeralsPlaceHolder(NumeralSet currentPlaceholdersNumerals)
        {
            return new NumeralsPlaceHolder(currentPlaceholdersNumerals);
        }

        private bool ValidateInput(int input)
        {
            if (input > 0 && input < 4000) return true; //input should be only numbers between 1 and 3999, inclusive
            return false;
        }
    }
}
