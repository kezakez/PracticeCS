using System.Collections.Generic;

namespace PracticeCS.NearbyWords
{
    public interface IWordHelper
    {
        bool IsWord(string word);
        List<char> LettersNear(char input);
    }
}