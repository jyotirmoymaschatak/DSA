class Solution {
    public int firstMissingPositive(int[] nums) {
         Arrays.sort(nums);
        
        int count = 1;

        for(int i = 0 ; i<nums.length; i++)
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