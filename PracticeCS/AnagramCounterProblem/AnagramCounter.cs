using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeCS.AnagramCounterProblem
{
    public class AnagramCounter
    {
        public static int CountAnagrams(List<string> input)
        {
            var countMap = new Dictionary<string, int>();
            foreach (var item in input)
            {
                var charArray = item.ToCharArray();
                Array.Sort(charArray);
                var key = new string(charArray);
                if (countMap.ContainsKey(key))
                {
                    countMap[key] += 1;
                }
                else
                {
                    countMap[key] = 1;
                }
            }
            return countMap.Values.Where(item => item > 1).Sum();
        }
    }
}
