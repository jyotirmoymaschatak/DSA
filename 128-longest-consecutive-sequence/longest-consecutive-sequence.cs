public class Solution {
    public int LongestConsecutive(int[] nums) {

        if(nums.Length == 0 ) return 0; 
         Array.Sort(nums);
            
            int CL=1;
            int ML=1;
            
            for(int i = 1 ; i<nums.Length; i++)
            {
               if(nums[i] == nums[i-1]+1)
               {
                   CL++;
                   ML = Math.Max(ML, CL);
               }
               else if(nums[i]!=nums[i-1])
               {
                   CL = 1;
               }
            }
            return ML;
    }
}