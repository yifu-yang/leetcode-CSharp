public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int length = nums.Length;
        int start = 0, end = length - 1, mid = (start + end) / 2;

        if (target < nums[start])
            return start;
        if (target > nums[end])
            return length;
        while (start <= end)
        {
            if (nums[mid] == target)
            {
                return mid;
            }
            if (target > nums[mid])
            {
                start = mid + 1;
            }
            else {
                end = mid - 1;
            }
            mid = (start + end) / 2;
        }

        if (nums[mid] < target)
            return mid + 1;
        else
            return mid;
    }
}