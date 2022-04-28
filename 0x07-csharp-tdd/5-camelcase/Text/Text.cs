using System;

namespace Text
{
    /// <sumary> Statement for Str class </sumary>
    public class Str
    {
        /// <sumary>
        /// Method that determines how many words are in a string. Each word begins with a capital letter except the first word. 
        /// <param name="s"> String </param>
        /// </sumary>
        public static int CamelCase(string s)
        {
            string capitalLetters = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            if (s.Length == 0)
                return 0;
            int counter = 1;
            for (int i = 0; i < s.Length; i++)
            {
                string ch = "";
                ch += s[i];
                if (capitalLetters.Contains(ch) && i != 0)
                    counter++;
            }
            return counter;
        }
    }
}
