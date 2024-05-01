public class Solution {
    public int[] Shuffle(int[] nums, int n) {

        int[] newArr = new int[nums.Length];
        for (int i = 0; i < n; i++)
        {
            newArr[2 * i] = nums[i];
            newArr[(2 * i) + 1] = nums[i + n];
        }

        return newArr;
    }
}