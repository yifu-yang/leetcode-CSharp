public class Solution {
    public void Rotate(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0) ; i++) 
            {
                for (int j = 0; j < matrix.GetLength(1)/2; j++) 
                {
                    int tmp = int.MaxValue;
                    tmp = matrix[i, j];
                    matrix[i, j] = matrix[i, matrix.GetLength(1) - j - 1];
                    matrix[i, matrix.GetLength(1) - j - 1] = tmp;
                }
            }


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) ; j++)
                {
                    if (i + j < matrix.GetLength(0) - 1) 
                    {
                        int tmp = int.MaxValue;
                        tmp = matrix[i, j];
                        matrix[i, j] = matrix[matrix.GetLength(0) - 1 - j, matrix.GetLength(0) - 1 - i];
                        matrix[matrix.GetLength(0) - 1 - j, matrix.GetLength(0) - 1 - i] = tmp;
                    }
                }
            }
        }
}