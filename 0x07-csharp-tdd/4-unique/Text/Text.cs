using System;
using System.Linq;

namespace Text
{
    /// <sumary> Statement for Str class </sumary>
    public class Str
    {
        /// <sumary>
        /// Method that returns the index of the first non-repeating character of a string.
        /// <param name="s"> String </param>
        /// </sumary>
        public static int UniqueChar(string s)
        {
            if (s == "")
                return -1;
            char[] array = s.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int count = array.Count(f => (f == s[i]));
                if (count == 1)
                    return i;
            }
            return -1;
        }
    }
}
