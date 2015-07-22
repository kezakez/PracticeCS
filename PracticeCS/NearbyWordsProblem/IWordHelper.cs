using System.Collections.Generic;

namespace PracticeCS.NearbyWordsProblem
{
    public interface IWordHelper
    {
        bool IsWord(string word);
        List<char> LettersNear(char input);
    }
}