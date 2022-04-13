﻿using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][] {
                new int [4] {0, 1, 2, 3},
                new int [7] {0, 1, 2, 3, 4, 5, 6},
                new int [2] {0, 1},
            };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j]);
                    if (j != jaggedArray[i].Length -1)
                        Console.Write(" ");
                }
                 Console.WriteLine();
            }
        }
    }
}
