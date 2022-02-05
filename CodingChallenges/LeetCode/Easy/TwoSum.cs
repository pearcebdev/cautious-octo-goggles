namespace CodingChallenges.LeetCode.Easy;

public class TwoSum
{
    public static int[] Solve(int[] nums, int target)
    {
        var answer = new int[2];
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    answer[0] = i;
                    answer[1] = j;
                }
            }
        }

        return answer;
    }

    public static int[] SolveWithDictionary(int[] nums, int target)
    {
        var dictionary = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            // if a + b = target, instead solve for a = target - b
            var a = target - nums[i];
            // if the value a already exists in our dictionary, we have our solution
            if (dictionary.ContainsKey(a))
            {
                // location of a in dictionary, b is current index
                return new[] {dictionary[a], i};
            }
            // if the value a does not yet exist, add a new entry to the dictionary to check next iteration
            // if this value is a possible solution
            if (!dictionary.ContainsKey(nums[i]))
            {
                dictionary.Add(nums[i], i);
            }
            
        }
        
        // we didn't find a solution
        return new []{0,0};
    }
}