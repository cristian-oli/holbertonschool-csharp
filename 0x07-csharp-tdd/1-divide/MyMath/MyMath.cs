using System;

namespace MyMath
{
    /// <sumary> class Matrix </sumary>
    public class Matrix
    {
        /// <sumary>
        /// Method that divides all elements in the matrix by num
        /// <param name="matrix"> 2D Array </param>
        /// <param name="num"> Divisor </param>
        /// </sumary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return null;
            int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)]; 
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
               {     
                    try
                    {
                        newMatrix[i,j] = matrix[i,j] / num;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Num cannot be 0");
                        return null;
                    }
                }
            }
            return newMatrix;
        }
    }
}
