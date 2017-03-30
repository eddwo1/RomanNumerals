namespace RomanNumeralsAutoVerificationRunner
{
    public class NumberNumeralConversions
    {
        public int Number { get; set; }
        public string ExpectedConversion { get; set; }
        private string _actualResult;
        public string ActualResult
        {
            get
            {
                return _actualResult;
            }
            set
            {
                this._actualResult = value;
                WasCorrectResult = ExpectedConversion == _actualResult;
            }
        }
        public bool WasCorrectResult { get; set; }

        public NumberNumeralConversions(int number, string expected)
        {
            this.Number = number;
            this.ExpectedConversion = expected;
        }

        public override string ToString()
        {
            return string.Concat(Number, " Expected: ", ExpectedConversion, " Actual: ", ActualResult, (WasCorrectResult)? " Success!" : " Fail!");
        }

    }
}
