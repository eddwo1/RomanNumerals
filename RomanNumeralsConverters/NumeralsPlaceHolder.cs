using RomanNumeralsConverters.Interfaces;
using System;

namespace RomanNumeralsConverters
{
    public class NumeralsPlaceHolder : RomanNumeralGenerator
    {
        public char UpperNumeralsChar { get; set; }
        public char LowerNumeralsChar { get; set; }

        public char NextPlaceHoldersLowerNumeralsChar { get; set; }
        public int PlaceHolderValue { get; set; }
        private string PlaceHolderNumeralString { get; set; }


        public NumeralsPlaceHolder(NumeralSet numeral)
        {
            this.UpperNumeralsChar = numeral.UpperNumeralSymbol;
            this.LowerNumeralsChar = numeral.LowerNumeralSymbole;
            this.NextPlaceHoldersLowerNumeralsChar = numeral.NextPlaceholdersLowerNumeralSymbol;
        }

        //well, in here, it no longer is concerned with place holders, really.
        //not concerned with 10 ^ x.
        //Here is knows only of a number and three symbols.
        
        public string generate(int placeHolderValue)
        {
            this.PlaceHolderValue = placeHolderValue;
            if (PlaceHolderValue < 4)
            {//If the number if less than 4, use the lower bounds symbols n times
                //where n is the value of time the place holder known to thee calling class
                PlaceHolderNumeralString = new String(LowerNumeralsChar, PlaceHolderValue);
            }
            else if (PlaceHolderValue == 4)
            {//if it is 4, use the upper bound symbol and put the lower bound symbol before it.
                PlaceHolderNumeralString = string.Concat(LowerNumeralsChar, UpperNumeralsChar);
            }
            else if (PlaceHolderValue == 5)
            {//if its just 5, use upper bound symbol
                PlaceHolderNumeralString = UpperNumeralsChar.ToString();
            }
            else if(PlaceHolderValue < 9)
            {//less than 9 is upper bounds symber with the addition of the lower bounds symbol n times (where n is placeholder value - 5)
                PlaceHolderNumeralString = string.Concat(UpperNumeralsChar, new String(LowerNumeralsChar, PlaceHolderValue -5));
            }
            else
            {//9 requires I before y, where y is the symbol from the lower bounds of the next power up!
                PlaceHolderNumeralString = string.Concat(LowerNumeralsChar, NextPlaceHoldersLowerNumeralsChar);
            }

            return PlaceHolderNumeralString;
            //return...
        }
    }
}
