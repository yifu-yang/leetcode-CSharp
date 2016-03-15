public class Solution
{

    public IList<string> LetterCombinations(string digits)
    {
        string[] nums = new string[] { " ", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
        var input = digits.Select(x => Convert.ToInt32(x.ToString())).ToArray();
        List<string> res = new List<string>();
        List<string> tmp = new List<string>();
        foreach (var index in input)
        {
            foreach (var cha in nums[index])
            {
                if (res.Count != 0)
                {
                    foreach (var sent in res)
                    {
                        tmp.Add(sent + cha);
                    }
                }
                else { tmp.Add(cha.ToString()); }
            }

            res = new List<string>(tmp);

        }

        return res.Where(x => x.Length == input.Length).ToList();
    }
}