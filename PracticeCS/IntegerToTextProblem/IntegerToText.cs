using System.Collections.Generic;

namespace PracticeCS.IntegerToTextProblem
{
    /*
    integer to english
    int -> string
    0 < n < 10^12
    123 -> "One hundred and twenty three"
    1 234 567 -> "One million two hundred and thirty four thousand five hundred and sixty seven"
    */
    public class IntegerToText
    {
        private static readonly Dictionary<int, string> DigitsMapping = new Dictionary<int, string>()
        {
            {0, ""},
            {1, "one"},
            {2, "two"},
            {3, "three"},
            {4, "four"},
            {5, "five"},
            {6, "six"},
            {7, "seven"},
            {8, "eight"},
            {9, "nine"},
            {10, "ten"},
            {11, "eleven"},
            {12, "twelve"},
            {13, "thirteen"},
            {14, "fourteen"},
            {15, "fifteen"},
            {16, "sixteen"},
            {17, "seventeen"},
            {18, "eighteen"},
            {19, "nineteen"}
        };

        private static readonly Dictionary<int, string> TensMapping = new Dictionary<int, string>() {
            {0, "" },
            {1, "ten"},
            {2, "twenty"},
            {3, "thirty"},
            {4, "fourty"},
            {5, "fifty"},
            {6, "sixty"},
            {7, "seventy"},
            {8, "eighty"},
            {9, "ninety"},
        };

        private static readonly Dictionary<int, string> PositionMapping = new Dictionary<int, string>() {
            {0,""},
            {1,""},
            {2,"thousand"},
            {3,"million"},
            {4,"billion"},
            {5,"trillion"}
        };

        public static string IntegerToEnglish(long input)
        {
            string result = "";

            var inputString = input.ToString();

            var groups = new List<string>();
            string currentGroup = "";
            for (int index = inputString.Length-1; index >= 0; index--)
            {
                currentGroup = inputString[index] + currentGroup;
                if (currentGroup.Length == 3)
                {
                    groups.Insert(0, currentGroup);
                    currentGroup = "";
                }
            }
            if (currentGroup.Length > 0) groups.Insert(0, currentGroup);

            var groupIndex = groups.Count;
            foreach (var digitGroup in groups)
            {
                if (digitGroup == "000") continue;
                result += " " + GetGroupingHundredText(digitGroup);
                result += " " + PositionMapping[groupIndex];
                groupIndex -= 1;
            }

            return result.Trim();
        }

        private static string GetGroupingHundredText(string group)
        {
            string result = "";
            if (group.Length == 1)
            {
                int index = int.Parse(group[0].ToString());
                result = DigitsMapping[index];
            }
            else if (group.Length == 2)
            {
                int index = int.Parse(group);
                if (DigitsMapping.ContainsKey(index))
                {
                    result = DigitsMapping[index];
                }
                else
                {
                    index = int.Parse(group[0].ToString());
                    result += TensMapping[index];

                    result += " " + GetGroupingHundredText(group[1].ToString());
                }
            }
            else if (group.Length == 3)
            {
                int index = int.Parse(group[0].ToString());
                result = DigitsMapping[index];

                var twodigitresult = GetGroupingHundredText(group[1].ToString() + group[2].ToString());
                result += " hundred";
                if (!string.IsNullOrWhiteSpace(twodigitresult)) result += string.Format(" and {0}", twodigitresult);
            }
            return result;
        }
    }
}
