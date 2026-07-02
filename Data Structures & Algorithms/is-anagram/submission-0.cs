public class Solution {
    public bool IsAnagram(string s, string t) {
    // Step 1: If lengths differ, they can't be anagrams
        if (s.Length != t.Length) {
            return false;
        }

        // Step 2: Create a frequency counter for the 26 lowercase letters
        int[] charCounts = new int[26];

        for (int i = 0; i < s.Length; i++) {
            // Subtract 'a' to map characters to indices 0-25
            charCounts[s[i] - 'a']++;
            charCounts[t[i] - 'a']--;
        }

        // Step 3: Check if all counts are zero
        foreach (int count in charCounts) {
            if (count != 0) {
                return false;
            }
        }

        return true;
    }
}
