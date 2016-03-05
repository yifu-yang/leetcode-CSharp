public class Solution {
    public int RemoveElement(int[] nums, int val)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var i in nums)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                {
                    dict.Add(i, 1);
                }
            }
            if (dict.ContainsKey(val))
                dict[val] = 0;
            List<int> tmp = new List<int>();
            int index=0;
            foreach (var key in dict.Keys)
            {
                if (dict[key] != 0) { 
                for (int i = 0; i < dict[key]; i++)
                {
                    nums[index] = key;
                    index++;
                }
                }


            }
            return index;
        }
}