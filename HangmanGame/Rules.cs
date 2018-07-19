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
        const int MAX_NUM_OF_ATTEMPTS = 7;

        public static bool IsALetter(char input)
        {
            return Regex.IsMatch(input.ToString(), "[a-z]", RegexOptions.IgnoreCase);
        }

        public static bool WordContains(string word, char input)
        {
            return Regex.IsMatch(word, input.ToString(), RegexOptions.IgnoreCase);
        }

        public static bool OutOfAttempts(int attempts)
        {
            if(attempts == MAX_NUM_OF_ATTEMPTS)
            {
                return true;
            }

            return false;
        }
    }
}
