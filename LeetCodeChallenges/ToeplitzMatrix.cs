namespace Resolved;

// Link to challenge:https://leetcode.com/problems/toeplitz-matrix/description/
public class ToeplitzMatrix
{
    public void Verify() 
    {
        var matrix = new int[3][];
        matrix[0] = [1, 2, 3, 4];
        matrix[1] = [5, 1, 2, 3];
        matrix[2] = [9, 5, 1, 2];

        bool verify = true;
        for (int row = 0; row < matrix.Length-1; row++) 
        {
            for (int column = 0; column < matrix[row].Length-1; column++) 
            {
                if (matrix[row][column] != matrix[row + 1][column + 1])
                    verify = false;
            }
        }

        if (verify)
            Console.WriteLine("The matrix is toeplitz!");
        else
            Console.WriteLine("The matrix is not toeplitz!");
    }
}
