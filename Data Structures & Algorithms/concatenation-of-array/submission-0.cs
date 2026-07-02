public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length;
        // Create a new array with double the length
        int[] ans = new int[2 * n];

        for (int i = 0; i < n; i++) {
            // Fill the first half
            ans[i] = nums[i];
            
            // Fill the second half at the same time
            ans[i + n] = nums[i];
        }

        return ans;
    
    }
}