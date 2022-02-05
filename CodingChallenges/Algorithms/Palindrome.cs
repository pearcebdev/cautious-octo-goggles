namespace CodingChallenges.Algorithms;

/// <summary>
/// Class for detecting if words are palindromes.
/// </summary>
public static class Palindrome
{
    public static bool IsPalindrome1(string word)
    {
        var backwards = "";

        for (var i = word.Length - 1; i >= 0; i--)
        {
            backwards += word[i];
        }
        return backwards == word;
    }

    public static bool IsPalindrome2(string word)
    {
        // Strip outermost characters if same, return false when mismatch.

        while (word.Length > 1)
        {
            if (word[0] != word[^1])
                return false;
            word = word[1..^1];
        }

        return true;
    }
}