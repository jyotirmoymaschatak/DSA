public class Solution {
    public int[] BuildArray(int[] nums) {

        int[] op = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
            {
                op[i] = nums[nums[i]];
            }
        
    return op;
        
    }
}