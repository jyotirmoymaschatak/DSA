public class Solution {
    public int[] GetConcatenation(int[] nums) {
        
        int l = nums.Length;
        int[] ans = new int[2 * l];
        int index=0;
        for(int j = 0; j < 2; j++)
        {
            for(int i=0 ; i< l ; i++)
            {
                ans[index++] = nums[i];
            }
        }
        

        return ans;
    }
}