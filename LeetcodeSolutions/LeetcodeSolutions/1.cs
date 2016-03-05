public class Solution
    {
        public Tuple<int, int> TwoSum(int[] numbers, int target)
        {
            var dict = new Dictionary<string, List<int>>();
            int i = 1;
            foreach (int t in numbers)
            {
                if (dict.ContainsKey(t.ToString()))
                    dict[t.ToString()].Add(i);
                else
                {
                    List<int> l = new List<int>();
                    l.Add(i);
                    dict.Add(t.ToString(), l);
                }
                i++;
            }
            foreach (int t in numbers)
            {
                int sub = target - t;
                if (t != sub)
                {
                    if (dict.ContainsKey(sub.ToString()))
                    {
                        return Tuple.Create(dict[t.ToString()][0], dict[sub.ToString()][0]);
                    }
                }
                else
                {
                    if (dict[t.ToString()].Count > 1)
                        return Tuple.Create(dict[t.ToString()][0], dict[t.ToString()][1]);
                }
            }
            return Tuple.Create(0, 0);
        }
    }