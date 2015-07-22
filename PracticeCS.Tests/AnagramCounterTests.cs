using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using PracticeCS.AnagramCounterProblem;

namespace PracticeCS.Tests
{
    [TestClass]
    public class AnagramCounterTests
    {
        [TestMethod]
        public void CharacterAtPostion_should_ReturnValidResults()
        {
            AnagramCounter.CountAnagrams(new List<string>()).ShouldEqual(0);
            AnagramCounter.CountAnagrams(new List<string>() { "a" }).ShouldEqual(0);
            AnagramCounter.CountAnagrams(new List<string>() { "a", "b", "c" }).ShouldEqual(0);
            AnagramCounter.CountAnagrams(new List<string>() { "test", "estt", "best" }).ShouldEqual(2);
            AnagramCounter.CountAnagrams(new List<string>() { "test", "estt", "best", "good", "doog" }).ShouldEqual(4);
        }
    }
}
