public class Solution
{
    public void Rotate(int[] nums, int ke)
    {
        int n = nums.Length;
        ke = ke % n;


        Reverse(nums, 0, n - 1);


        Reverse(nums, 0, ke - 1);

        Reverse(nums, ke, n - 1);
    }

    private void Reverse(int[] nums, int start, int end)
    {
        while (start < end)
        {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
            //done

        }
    }
}