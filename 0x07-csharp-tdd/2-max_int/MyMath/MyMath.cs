using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <sumary> Statement for Operations class </sumary>
    public class Operations
    {
        /// <sumary>
        /// Method that return the max integer
        /// <param name="nums"> List of integeres </param> 
        /// </sumary>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
                return 0;

            int number = Int32.MinValue;
            foreach (int element in nums)
            {
                if (number < element)
                    number = element;
            }
            return number;
        }
    }
}
