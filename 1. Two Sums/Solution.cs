public class Solution {
    public static int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numDict = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (numDict.ContainsKey(complement)) {
                return new int[] { numDict[complement], i };
            }
            numDict[nums[i]] = i;
        }
        
        throw new ArgumentException("No two sum solution");
    }

    public static void Run() {
        int[] nums = new int[] {3,2,4};
        int target = 6;
        int[] result = TwoSum(nums, target);
        Console.WriteLine(string.Join(", ", result));
    }
}