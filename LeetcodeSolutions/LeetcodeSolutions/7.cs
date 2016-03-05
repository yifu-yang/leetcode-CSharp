public class Solution
    {
        public int Reverse(int x)
        {
            long tmp = 0;
            int t = 1;
            if (x < 0)
            {
                x = -x;
                t = -1;
            }
            while (x / 10 > 0)
            {
                tmp = tmp * 10 + x % 10;
                x = x / 10;
                if ((tmp * 10) >= int.MaxValue)
                {
                    return 0;
                }
            }
            tmp = tmp * 10 + x;
            tmp=(int)tmp * t;
            if ((int)tmp < int.MaxValue && (int)tmp>int.MinValue)
                return (int)tmp;
            else
                return 0;
        }
    }‍