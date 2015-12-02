public class Solution {
    Dictionary<int, int> dict = new Dictionary<int, int>();
        public int ClimbStairs(int n)
        {    
            if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 2;
            } 
            else
            {
                int step1 = 0;
                if (dict.ContainsKey(n - 1))
                {
                    step1 = dict[n - 1];
                }
                else
                {
                    dict.Add(n - 1, ClimbStairs(n - 1));
                    step1=ClimbStairs(n - 1);
                }

                int step2 = 0;
                if (dict.ContainsKey(n - 2))
                {
                    step2 = dict[n - 2];
                }
                else
                {
                    dict.Add(n - 2, ClimbStairs(n - 2));
                    step2 = ClimbStairs(n - 2);
                }

                return step1 + step2;
            }
        }
}
