public class Solution {
    public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (numRows <= 0){
                return result;
            }
            for (int index = 1; index <= numRows; index++)
            {
                if (numRows == 1)
                {
                    IList<int> s = new List<int>();
                    s.Add(1);
                    result.Add(s);
                }
                else
                {
                    IList<int> s = new List<int>();
                    for (int i = 0; i < index; i++)
                    {
                        if (i == 0 || i == index - 1)
                        {
                            s.Add(1);
                        }
                        else
                        {
                            s.Add(result[index - 2][i] + result[index - 2][i - 1]);
                        }
                    }
                    result.Add(s);
                }
            }
            return result;
        }
}