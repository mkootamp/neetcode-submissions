public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
         // Create a dictionary where the Key is the number and Value is its index
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();
       
        // Start a loop to iterate through the array using index i
        for (int i = 0; i < nums.Length; i++)
        {
            // Calculate the value needed to reach the target (complement)
            int complement = target - nums[i];
           
            // Check if the dictionary already contains the complement we need
            if (numToIndex.ContainsKey(complement)) {
                // If found, return the index of the complement and the current index
                return new int[] { numToIndex[complement], i };
            }
           
            // Check if the current number is not already in the dictionary
            if (!numToIndex.ContainsKey(nums[i])) {
                // Add the current number and its index to the dictionary for later use
                numToIndex.Add(nums[i], i);
            }
        }    
        // Return an empty array if no solution is found, though the problem assumes one exists
        return new int[0];
    }
}
