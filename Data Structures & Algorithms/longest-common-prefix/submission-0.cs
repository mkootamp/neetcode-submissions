public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        
   // Edge case
        if (strs == null || strs.Length == 0)
            return "";

        // Start with the first string as prefix
        string prefix = strs[0];

        // Compare prefix with each string
        for (int i = 1; i < strs.Length; i++)
        {
            // Reduce prefix until it matches the start of current string
            while (!strs[i].StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);

                // If prefix becomes empty
                if (prefix == "")
                    return "";
            }
        }

        return prefix;
    }
}