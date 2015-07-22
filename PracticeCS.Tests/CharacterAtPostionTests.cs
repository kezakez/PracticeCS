using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeCS.CharacterPositionProblem;
using Should;

namespace PracticeCS.Tests
{
    [TestClass]
    public class CharacterAtPostionTests
    {
        [TestMethod]
        public void CharacterAtPostion_should_ReturnValidResults()
        {
            CharacterPosition.GetCharacter(0).ShouldEqual('0');

            CharacterPosition.GetCharacter(11).ShouldEqual('0');

            CharacterPosition.GetCharacter(1).ShouldEqual('1');

            CharacterPosition.GetCharacter(24).ShouldEqual('1');

            CharacterPosition.GetCharacter(33).ShouldEqual('1');

            CharacterPosition.GetCharacter(23).ShouldEqual('6');

            CharacterPosition.GetCharacter(9999).ShouldEqual('7');
        }
    }
}
