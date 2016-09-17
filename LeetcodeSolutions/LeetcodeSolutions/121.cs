public class Solution
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Length == 0)
            return 0;
        var Min = new List<int>();
        var minValue = prices[0];
        foreach (var i in prices)
        {
            if (i < minValue)
            {
                minValue = i;
                Min.Add(i);
            }
            else
            {
                Min.Add(minValue);
            }
        }
        var max = 0;
        var maxDay = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] - Min[i] > max)
            {
                maxDay = i;
                max = prices[i] - Min[i];
            }
        }
        return max;
    }
}