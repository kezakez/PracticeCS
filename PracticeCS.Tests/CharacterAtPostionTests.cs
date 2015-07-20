using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace PracticeCS.Tests
{
    [TestClass]
    public class CharacterAtPostionTests
    {
        [TestMethod]
        public void CharacterAtPostion_should_ReturnValidResults()
        {
            var target = new CharacterAtPosition.CharacterAtPosition();

            target.GetCharacter(0).ShouldEqual('0');

            target.GetCharacter(11).ShouldEqual('0');

            target.GetCharacter(1).ShouldEqual('1');

            target.GetCharacter(24).ShouldEqual('1');

            target.GetCharacter(33).ShouldEqual('1');

            target.GetCharacter(23).ShouldEqual('6');

            target.GetCharacter(9999).ShouldEqual('7');
        }
    }
}
