public class Solution
{
    public int MaxRotateFunction(int[] A)
    {
        if (A.Length == 0)
            return 0;
        var result = int.MinValue;
        var n = A.Length;
        for (int i = 0; i < n; i++)
        {
            var tmp = 0;
            int j = n - i;
            int p = 0;
            for (; j < n; j++, p++)
            {
                tmp += A[j] * p;
            }
            for (int k = 0; k < n - i; k++)
            {
                tmp += A[k] * (k + i);
            }
            if (tmp > result)
                result = tmp;
        }
        return result;
    }
}