using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeCS.IntegerToTextProblem;
using Should;

namespace PracticeCS.Tests
{
    [TestClass]
    public class IntegerToTextTests
    {
        [TestMethod]
        public void TestIntegerToEnglish()
        {
            IntegerToText.IntegerToEnglish(1).ShouldEqual("one");

            IntegerToText.IntegerToEnglish(5).ShouldEqual("five");

            IntegerToText.IntegerToEnglish(11).ShouldEqual("eleven");

            IntegerToText.IntegerToEnglish(19).ShouldEqual("nineteen");

            IntegerToText.IntegerToEnglish(20).ShouldEqual("twenty");

            IntegerToText.IntegerToEnglish(120).ShouldEqual("one hundred and twenty");

            IntegerToText.IntegerToEnglish(103).ShouldEqual("one hundred and three");

            IntegerToText.IntegerToEnglish(123).ShouldEqual("one hundred and twenty three");

            IntegerToText.IntegerToEnglish(111).ShouldEqual("one hundred and eleven");

            IntegerToText.IntegerToEnglish(1100).ShouldEqual("one thousand one hundred");

            IntegerToText.IntegerToEnglish(11000).ShouldEqual("eleven thousand");

            IntegerToText.IntegerToEnglish(1900).ShouldEqual("one thousand nine hundred");

            IntegerToText.IntegerToEnglish(19000).ShouldEqual("nineteen thousand");

            IntegerToText.IntegerToEnglish(1234567).ShouldEqual("one million two hundred and thirty four thousand five hundred and sixty seven");

            IntegerToText.IntegerToEnglish((long)Math.Pow(10, 12) - 1).ShouldEqual("nine hundred and ninety nine billion nine hundred and ninety nine million nine hundred and ninety nine thousand nine hundred and ninety nine");

            IntegerToText.IntegerToEnglish((long)Math.Pow(10, 12)).ShouldEqual("one trillion");
            
        }
    }
}
