public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int i = 0;
        bool startZero = true;
        List<int> res = new List<int>();
        for (i = 0; i < digits.Length; i++)
        {
            if (startZero && digits[i] == 0)
            {
                continue;
            }
            else
            {
                res.Add(digits[i]);
                startZero = false;
            }
        }
        if (res.Count == 0)
            res.Add(1);
        else
            res[res.Count - 1] += 1;
        int upgrade = 0;
        for (i = res.Count - 1; i >= 0; i--)
        {
            res[i] += upgrade;
            if (res[i] / 10 > 0)
            {
                upgrade = res[i] / 10;
                res[i] = res[i] % 10;
            }
            else
                upgrade = 0;
        }
        if (upgrade > 0)
            res.Insert(0, upgrade);
        return res.ToArray();
    }
}