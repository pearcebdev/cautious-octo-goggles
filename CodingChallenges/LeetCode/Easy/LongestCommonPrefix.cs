namespace CodingChallenges.LeetCode.Easy;

public class LongestCommonPrefix
{
    public string Solve(string[] strs)
    {
        if (strs.Length == 1)
            return strs[0];
        Array.Sort(strs);
        var firstString = strs[0];

        var i = 0;
        var prefix = "";
        while (i < firstString.Length)
        {
            for (int j = 1; j < strs.Length; j++)
            {
                if (firstString[i] == strs[j][i])
                    prefix += firstString.Substring(0, i);
                else
                    return prefix;
            }
        }

        return prefix;
    }
}