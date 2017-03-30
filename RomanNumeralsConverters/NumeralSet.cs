namespace RomanNumeralsConverters
{
    public class NumeralSet
    {
        public char UpperNumeralSymbol { get; set; } 
        public char LowerNumeralSymbole { get; set; }
        public char NextPlaceholdersLowerNumeralSymbol { get; set; }

        public NumeralSet(char lowerNumeral, char upperNumeral, char nextPlaceholdersLowerNumeral)
        {
            this.LowerNumeralSymbole = lowerNumeral;
            this.UpperNumeralSymbol = upperNumeral;
            this.NextPlaceholdersLowerNumeralSymbol = nextPlaceholdersLowerNumeral;
        }
    }
}
