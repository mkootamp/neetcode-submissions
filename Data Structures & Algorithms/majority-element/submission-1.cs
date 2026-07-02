public class Solution {
    public int MajorityElement(int[] nums) {

        Dictionary<int, int> count = new Dictionary<int, int>();

    foreach (int num in nums)
    {
        if (count.ContainsKey(num))
            count[num]++;
        else
            count[num] = 1;

        if (count[num] > nums.Length / 2)
            return num;
    }

    return -1;
        
    }

}