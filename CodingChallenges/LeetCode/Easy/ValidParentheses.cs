namespace CodingChallenges.LeetCode.Easy;

public class ValidParentheses
{
    public bool IsValid(string s)
    {
        if (s.Length == 1)
            return false;
        var parenMap = new Dictionary<char, char>
        {
            {'(', ')'},
            {'[', ']'},
            {'{', '}'}
        };
        var stack = new Stack<char>();
        foreach (var t in s)
        {
            if (IsLeftParen(t))
            {
                stack.Push(parenMap[t]);
            }
            else if (stack.Count > 0)
            {
                var pop = stack.Pop();
                if (pop != t)
                    return false;
            }
            else
            {
                return false;
            }
        }
        
        return stack.Count == 0;
    }

    private static bool IsLeftParen(char c)
    {
        switch (c)
        {
            case '(':
            case '{':
            case '[':
                return true;
            default:
                return false;
        }
    }
}