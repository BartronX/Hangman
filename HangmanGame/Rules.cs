using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HangmanGame
{
    public static class Rules
    {
        public static bool isALetter(char input)
        {
            return Regex.IsMatch(input.ToString(), "[a-z]", RegexOptions.IgnoreCase);
        }

        public static bool letterContains(string word, char input)
        {
            return Regex.IsMatch(word, input.ToString(), RegexOptions.IgnoreCase);
        }
    }
}
