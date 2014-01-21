using System;
using System.Numerics;

class Indices
{
    static void Main()
    {
        string brackets = Console.ReadLine();
        int count = brackets.Length;
        BigInteger[][] matrix = new BigInteger[2][];
        matrix[0] = new BigInteger[count + 2];
        matrix[1] = new BigInteger[count + 2];
        matrix[0][0] = 1;
        for (int row = 1; row <= count; row++)
        {
            if (brackets[row- 1] == '(')
            {
                matrix[1][0] = 0;
            }
            else
            {
                matrix[1][0] = matrix[0][1];
            }
            for (int col = 1; col <= count; col++)
            {
                if (brackets[row- 1] == '(')
                {
                    matrix[1][col] = matrix[0][col - 1];
                }
                else if (brackets[row- 1] == ')')
                {
                    matrix[1][col] = matrix[0][col + 1];
                }
                else
                {
                    matrix[1][col] = matrix[0][col - 1] + matrix[0][col + 1]; 
                }
            }
            matrix[0] = matrix[1];
            matrix[1] = new BigInteger[count + 2];
        }
        Console.WriteLine(matrix[0][0]);
    }
}
