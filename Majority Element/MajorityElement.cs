
using System;
using System.Collections;

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int count = 0;
        int maj = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (count == 0) maj = nums[i];

            if (maj == nums[i]) count += 1;
            else count -= 1;
        }

        return maj;
    }
}
