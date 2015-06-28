using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeCS.NearbyWords
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

        public List<string> GetWords(string input)
        {
            if (string.IsNullOrEmpty(input)) return new List<string>();

            return GetPermutations(input, 0).ToList().Where(_wordHelper.IsWord).ToList();
        }

        private IEnumerable<string> GetPermutations(string input, int charIndex)
        {
            var result = new List<string>();

            var letters = _wordHelper.LettersNear(input[charIndex]);
            foreach (var letter in letters)
            {
                var charArray = input.ToCharArray();
                charArray[charIndex] = letter;
                var newWord = new String(charArray);

                if (charIndex + 1 < input.Length)
                {
                    result.AddRange(GetPermutations(newWord, charIndex + 1));
                }
                else
                {
                    result.Add(newWord);
                }
            }

            return result;
        }
    }
}
