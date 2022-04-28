using System;

namespace Text
{
    /// <sumary> Statement for Str class </sumary>
    public class Str
    {
        /// <sumary>
        /// Method that returns True if a string is a palindrome or False if it’s not.
        /// <param name="s"> String to verify if is Palidrome </param>
        /// </sumary>
        public static bool IsPalindrome(string s)
        {
            string copy = "";
            for (int i = s.Length - 1; i > -1; i--)
            {
                copy += s[i];
            }
            copy = copy.Replace(" ", "").Replace(".", "").Replace(":", "").Replace(",", "").Replace(";", "").ToLower();
            s = s.Replace(" ", "").Replace(".", "").Replace(":", "").Replace(",", "").Replace(";", "").ToLower();
            if (s == copy)
                return true;
            return false;
        }
    }
}
