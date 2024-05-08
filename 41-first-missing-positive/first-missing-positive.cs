public class Solution {
    public int FirstMissingPositive(int[] nums) {

        Array.Sort(nums);
        
        int count = 1;

        for(int i = 0 ; i<nums.Length; i++)
        {
            if(nums[i] > 0)
            {
                if(nums[i] == count)
                    count++;

                else if(nums[i] > count)
                    return count;
            }
        }
        return count;
    }
}