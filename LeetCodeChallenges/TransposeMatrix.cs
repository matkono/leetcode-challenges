namespace Resolved;

public class TransposeMatrix
{
    public void Execute() 
    {
        var matrix = new int[3][];
        matrix[0] = [1, 2, 3];
        matrix[1] = [4, 5, 6];
        matrix[2] = [7, 8, 9];

        var rows = matrix.Length;
        var columns = matrix[0].Length;
        var transposedMatrix = new int[columns][];

        for (int row = 0; row < columns; row++)
        {
            transposedMatrix[row] = new int[rows];
            for (int column = 0; column < rows; column++)
            {
                transposedMatrix[row][column] = matrix[column][row];
            }
        }

        foreach (var row in transposedMatrix) 
        {
            foreach (var column in row)
                Console.Write(column);
            Console.WriteLine();
        }
    }
}
