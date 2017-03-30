using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralsConverters;

namespace RomanNumeralsConverters_Tests
{
    /// <summary>
    /// Summary description for NumeralsPlaceholder_Tests
    /// </summary>
    [TestClass]
    public class NumeralsPlaceholder_Tests
    {
        [TestMethod]
        public void Testing_1IsI()
        {
            var numeralsUnderTest = new NumeralSet('I', 'V', 'X');
            var NumeralsPlaceHolder = new NumeralsPlaceHolder(numeralsUnderTest);

            string expected = "I";
            int numberUnderTest = 1;
            string actual = NumeralsPlaceHolder.generate(1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Testing_2IsII()
        {
            var numeralsUnderTest = new NumeralSet('I', 'V', 'X');
            var NumeralsPlaceHolder = new NumeralsPlaceHolder(numeralsUnderTest);
            string expected = "II";
            int numberUnderTest = 2;
            string actual = NumeralsPlaceHolder.generate(numberUnderTest);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Testing_4IsIV()
        {
            var numeralsUnderTest = new NumeralSet('I', 'V', 'X');
            var NumeralsPlaceHolder = new NumeralsPlaceHolder(numeralsUnderTest);
            string expected = "IV";
            int numberUnderTest = 4;
            string actual = NumeralsPlaceHolder.generate(numberUnderTest);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Testing_5IsV()
        {
            var numeralsUnderTest = new NumeralSet('I', 'V', 'X');
            var NumeralsPlaceHolder = new NumeralsPlaceHolder(numeralsUnderTest);
            string expected = "V";
            int numberUnderTest = 5;
            string actual = NumeralsPlaceHolder.generate(numberUnderTest);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Testing_6IsVI()
        {
            var numeralsUnderTest = new NumeralSet('I', 'V', 'X');
            var NumeralsPlaceHolder = new NumeralsPlaceHolder(numeralsUnderTest);
            string expected = "VI";
            int numberUnderTest = 6;
            string actual = NumeralsPlaceHolder.generate(numberUnderTest);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Testing_9IsIX()
        {
            var numeralsUnderTest = new NumeralSet('I', 'V', 'X');
            var NumeralsPlaceHolder = new NumeralsPlaceHolder(numeralsUnderTest);
            string expected = "IX";
            int numberUnderTest = 9;
            string actual = NumeralsPlaceHolder.generate(numberUnderTest);

            Assert.AreEqual(expected, actual);
        }
        //above tests prove the class can return correct upper, lower or Y-before-N combination.
    }
}
