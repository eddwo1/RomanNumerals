using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralsConverters;

namespace RomanNumeralsConverters_Tests
{
    [TestClass]
    public class ClassicRomanNumeralsConverter_Tests
    {
        private ClassicRomanNumeralsConvert romanNumeralGenerator;

        [TestInitialize]
        public void Initialize()
        {
            romanNumeralGenerator = new RomanNumeralsConverters.ClassicRomanNumeralsConvert();
        }

        //prove input validation works correctly
        public void Testing_0isEmpty()
        {
            string expected = string.Empty;
            int numberUnderTest = 0;
            string actual = romanNumeralGenerator.generate(numberUnderTest);

            Assert.AreEqual(expected, actual);
        }

        public void Testing_4000isEmpty()
        {
            string expected = string.Empty;
            int numberUnderTest = 4000;
            string actual = romanNumeralGenerator.generate(numberUnderTest);

            Assert.AreEqual(expected, actual);
        }
        //prove various boundries return correct result
        [TestMethod]
         public void Testing_10IsX()
         {
            string expected = "X";
             int numberUnderTest = 10;
             string actual = romanNumeralGenerator.generate(numberUnderTest);

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void Testing_11IsXI()
         {
             string expected = "XI";
             int numberUnderTest = 11;
             string actual = romanNumeralGenerator.generate(numberUnderTest);

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void Testing_14IsXIV()
         {
             string expected = "XIV";
             int numberUnderTest = 14;
             string actual = romanNumeralGenerator.generate(numberUnderTest);

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void Testing_15IsXV()
         {
             string expected = "XI";
             int numberUnderTest = 11;
             string actual = romanNumeralGenerator.generate(numberUnderTest);

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void Testing_19IsXIX()
         {
             string expected = "XIX";
             int numberUnderTest = 19;
             string actual = romanNumeralGenerator.generate(numberUnderTest);

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void Testing_20IsXX()
         {
             string expected = "XX";
             int numberUnderTest = 20;
             string actual = romanNumeralGenerator.generate(numberUnderTest);

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void Testing_25IsXXV()
         {
             string expected = "XXV";
             int numberUnderTest = 25;
             string actual = romanNumeralGenerator.generate(numberUnderTest);

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void Testing_30IsXXX()
         {
             string expected = "XXX";
             int numberUnderTest = 30;
             string actual = romanNumeralGenerator.generate(numberUnderTest);

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void Testing_35IsXXXV()
         {
             string expected = "XXXV";
             int numberUnderTest = 35;
             string actual = romanNumeralGenerator.generate(numberUnderTest);

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void Testing_40IsXL()
         {
             string expected = "XL";
             int numberUnderTest = 40;
             string actual = romanNumeralGenerator.generate(numberUnderTest);

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void Testing_45IsVL()
         {
             string expected = "XLV";
             int numberUnderTest = 45;
             string actual = romanNumeralGenerator.generate(numberUnderTest);

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void Testing_50IsL()
         {
             string expected = "L";
             int numberUnderTest = 50;
             string actual = romanNumeralGenerator.generate(numberUnderTest);

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void Testing_55IsLV()
         {
             string expected = "LV";
             int numberUnderTest = 55;
             string actual = romanNumeralGenerator.generate(numberUnderTest);

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void Testing_60IsLV()
         {
             string expected = "LX";
             int numberUnderTest = 60;
             string actual = romanNumeralGenerator.generate(numberUnderTest);

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void Testing_90IsXC()
         {
             string expected = "XC";
             int numberUnderTest = 90;
             string actual = romanNumeralGenerator.generate(numberUnderTest);

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void Testing_100IsC()
         {
             string expected = "C";
             int numberUnderTest = 100;
             string actual = romanNumeralGenerator.generate(numberUnderTest);

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void Testing_101IsCI()
         {
             string expected = "CI";
             int numberUnderTest = 101;
             string actual = romanNumeralGenerator.generate(numberUnderTest);

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void Testing_105IsCV()
         {
             string expected = "CV";
             int numberUnderTest = 105;
             string actual = romanNumeralGenerator.generate(numberUnderTest);

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void Testing_109IsCIX()
         {
             string expected = "CIX";
             int numberUnderTest = 109;
             string actual = romanNumeralGenerator.generate(numberUnderTest);

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void Testing_110IsCX()
         {
             string expected = "CX";
             int numberUnderTest = 110;
             string actual = romanNumeralGenerator.generate(numberUnderTest);

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void Testing_115IsCXV()
         {
             string expected = "CXV";
             int numberUnderTest = 115;
             string actual = romanNumeralGenerator.generate(numberUnderTest);

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void Testing_120IsCXX()
         {
             string expected = "CXX";
             int numberUnderTest = 120;
             string actual = romanNumeralGenerator.generate(numberUnderTest);

             Assert.AreEqual(expected, actual);
         }

         [TestMethod]
         public void Testing_150IsCL()
         {
             string expected = "CL";
             int numberUnderTest = 150;
             string actual = romanNumeralGenerator.generate(numberUnderTest);

             Assert.AreEqual(expected, actual);
         }

        [TestMethod]
        public void Testing_500IsD()
        {
            string expected = "D";
            int numberUnderTest = 500;
            string actual = romanNumeralGenerator.generate(numberUnderTest);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Testing_999IsCMXCIX()
        {
            string expected = "CMXCIX";
            int numberUnderTest = 999;
            string actual = romanNumeralGenerator.generate(numberUnderTest);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Testing_1000IsM()
        {
            string expected = "M";
            int numberUnderTest = 1000;
            string actual = romanNumeralGenerator.generate(numberUnderTest);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Testing_3999IsMMMCMXCIX()
        {
            string expected = "MMMCMXCIX";
            int numberUnderTest = 3999;
            string actual = romanNumeralGenerator.generate(numberUnderTest);

            Assert.AreEqual(expected, actual);
        }
    }
}
