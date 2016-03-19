public class Solution
{
    public bool IsValidSudoku(char[,] board)
    {
        var rows = new List<HashSet<char>>();
        for (int i = 0; i < 9; i++)
        {
            rows.Add(new HashSet<char>());
        }
        var cols = new List<HashSet<char>>();
        for (int i = 0; i < 9; i++)
        {
            cols.Add(new HashSet<char>());
        }
        var squs = new List<HashSet<char>>();
        for (int i = 0; i < 9; i++)
        {
            squs.Add(new HashSet<char>());
        }

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (board[i, j].ToString() != ".")
                {
                    if (rows[i].Contains(board[i, j]))
                        return false;
                    else
                        rows[i].Add(board[i, j]);

                    if (cols[j].Contains(board[i, j]))
                        return false;
                    else
                        cols[j].Add(board[i, j]);


                    if (squs[i / 3 + j / 3 * 3].Contains(board[i, j]))
                        return false;
                    else
                        squs[i / 3 + j / 3 * 3].Add(board[i, j]);
                }
            }
        }
        return true;
    }
}