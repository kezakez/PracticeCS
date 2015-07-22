using System.Collections.Generic;
using System.Linq;

namespace PracticeCS.NearbyWordsProblem
{
    /// <summary>
    /// Get words has O(n^m) time complexity n is the string length, m is the character permutations
    /// </summary>
    public class NearbyWords
    {
        private readonly IWordHelper _wordHelper;

        public NearbyWords(IWordHelper wordHelper)
        {
            _wordHelper = wordHelper;
        }

        public IEnumerable<string> GetWords(string input)
        {
            if (string.IsNullOrEmpty(input)) return new List<string>();

            return GetPermutations(input, 0).Where(_wordHelper.IsWord);
        }

        private IEnumerable<string> GetPermutations(string input, int charIndex)
        {
            var letters = _wordHelper.LettersNear(input[charIndex]);
            foreach (var letter in letters)
            {
                var charArray = input.ToCharArray();
                charArray[charIndex] = letter;
                var newWord = new string(charArray);

                if (charIndex + 1 < input.Length)
                {
                    foreach (var result in GetPermutations(newWord, charIndex + 1))
                        yield return result;
                }
                else
                {
                    yield return newWord;
                }
            }
        }
    }
}
