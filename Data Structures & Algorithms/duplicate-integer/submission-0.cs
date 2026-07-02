public class Solution {
    public bool hasDuplicate(int[] nums) {
        // A HashSet only stores unique values. 
        // Checking if an item exists in a HashSet is extremely fast: O(1).
        HashSet<int> seen = new HashSet<int>();

        foreach (int n in nums) {
            // .Add() returns 'false' if the item already exists in the set
            if (!seen.Add(n)) {
                return true; 
            }
        }
        return false;      
    }
}