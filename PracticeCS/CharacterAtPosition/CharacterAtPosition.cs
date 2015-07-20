using System;

namespace PracticeCS.CharacterAtPosition
{
    /// <summary>
    /// Numbers are serialized increasingly into a sequence in the format of 0123456789101112131415,
    /// each digit occupies a position in the sequence. For instance, the digit in position 5 is 5, in position 13 is 1, in the position 19 is 4, and so on.
    /// Please write a function/method to get the digit for any given position.
    /// </summary>
    public class CharacterAtPosition
    {
        public char GetCharacter(int position)
        {
            var counter = 0;
            for (var current = 0; current <= position; current++)
            {
                var stringToAppend = current.ToString();
                if (counter == position)
                {
                    return stringToAppend[0];
                }
                counter += stringToAppend.Length;
                if (counter > position)
                {
                    return stringToAppend[stringToAppend.Length - (counter - position)];
                }
            }
            throw new InvalidOperationException("character position not valid");
        }
    }
}
