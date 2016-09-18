public class Solution
{
    public int FindNthDigit(int n)
    {
        double tmp = 0;
        double site = 0;
        if (n < 10)
            return n;
        for (int i = 1; ; i++)
        {
            if (n > tmp + 9 * Math.Pow(10, i - 1) * i)
            {
                tmp += 9 * Math.Pow(10, i - 1) * i;
                site += 9 * Math.Pow(10, i - 1);
                continue;
            }
            else
            {
                var k = n - tmp;
                var number = (int)k / i + site + ((int)k % i > 0 ? 1 : 0);
                return (number).ToString()[(int)(k - 1) % (i)] - '0';
            }
        }
    }
}