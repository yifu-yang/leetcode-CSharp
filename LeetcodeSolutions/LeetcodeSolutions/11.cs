public class Solution
{
    public int MaxArea(int[] height)
    {
        int res = 0;

        int left = 0, right = height.Length - 1;
        while (left != right)
        {
            int tmp = (right - left) * (height[left] > height[right] ? height[right] : height[left]);
            if (tmp > res)
                res = tmp;
            if (height[right] < height[left])
                right--;
            else
                left++;
        }
        return res;
    }
}