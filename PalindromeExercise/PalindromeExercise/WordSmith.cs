using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string str)
        {

            return str?.ToLower().SequenceEqual(str.Reverse()) ?? false;
        }
    }
}
