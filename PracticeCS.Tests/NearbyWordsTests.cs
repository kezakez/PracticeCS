using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PracticeCS.NearbyWordsProblem;
using Should;

namespace PracticeCS.Tests
{
    [TestClass]
    public class NearbyWordsTests
    {
        [TestMethod]
        public void NearbyWords_should_ReturnValidResults()
        {
            //arrange
            var target = new NearbyWords(new WordHelperStub());

            //act
            var result = target.GetWords("gi").ToList();

            //assert
            result.ShouldContain("hi");
            result.ShouldContain("go");
        }

        [TestMethod]
        public void NearbyWords_should_HandleEmptyWords()
        {
            //arrange
            var target = new NearbyWords(new WordHelperStub());

            //act
            var result = target.GetWords("");

            //assert
            result.Count().ShouldEqual(0);
        }

        [TestMethod]
        public void NearbyWords_should_HandleNullWords()
        {
            //arrange
            var target = new NearbyWords(new WordHelperStub());

            //act
            var result = target.GetWords(null);

            //assert
            result.Count().ShouldEqual(0);
        }

        [TestMethod]
        public void NearbyWords_should_ReturnCorrectNumberOfPermutations()
        {
            //arrange
            var helperMock = new Mock<IWordHelper>();
            helperMock.Setup(h => h.IsWord(It.IsAny<string>())).Returns(true);
            helperMock.Setup(h => h.LettersNear(It.IsAny<char>())).Returns(new List<char>(){'a','b','c'});

            var target = new NearbyWords(helperMock.Object);

            //act
            var result = target.GetWords("abc");

            //assert
            result.Count().ShouldEqual(27);
        }
    }

    public class WordHelperStub : IWordHelper
    {
        public bool IsWord(string word)
        {
            if (word == "go" || word == "hi") return true;
            return false;
        }

        public List<char> LettersNear(char input)
        {
            if (input == 'g') return new List<char>()
            {
                'g', 'h', 'j'
            };
            return new List<char>()
            {
                'i', 'k', 'o'
            };
        }

    }
}
