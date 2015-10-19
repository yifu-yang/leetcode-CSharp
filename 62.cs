public class Solution {
    Dictionary<string, int> dict;
        public int UniquePaths(int m, int n)
        {
            if (dict == default(object)) dict = new Dictionary<string, int>();
            if (m == 1)
                return 1;
            if (n == 1)
                return 1;
            if (dict.ContainsKey(string.Format("{0},{1}", m, n)))
                return dict[string.Format("{0},{1}", m, n)];
            else
            {
                if (!dict.ContainsKey(string.Format("{0},{1}", m - 1, n)))
                {
                    var tmp1 = UniquePaths(m - 1, n);
                    dict.Add(string.Format("{0},{1}", m - 1, n), tmp1);
                    if (!dict.ContainsKey(string.Format("{0},{1}", n, m - 1)))
                    dict.Add(string.Format("{0},{1}", n, m - 1), tmp1);
                }
                if (!dict.ContainsKey(string.Format("{0},{1}", m, n - 1)))
                {
                    var tmp2 = UniquePaths(m, n - 1);
                    dict.Add(string.Format("{0},{1}", n - 1, m), tmp2);
                    if (!dict.ContainsKey(string.Format("{0},{1}", m, n - 1)))
                    dict.Add(string.Format("{0},{1}", m, n - 1), tmp2);
                }
                return  dict[string.Format("{0},{1}", m - 1, n)] + dict[string.Format("{0},{1}", m , n-1)];
            }
        }
}
