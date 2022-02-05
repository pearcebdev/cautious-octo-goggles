namespace CodingChallenges.LeetCode.Easy;

public class RomanToInteger
{
    public int Solve(string s)
    {
        var charArray = s.ToCharArray();
        char? nextChar = null;
        var sum = 0;
        for (var i = 0; i < charArray.Length; i++)
        {
            if (i != charArray.Length - 1)
            {
                nextChar = charArray[i+1];
            }

            switch (charArray[i])
            {
                case 'I':
                    if (nextChar is 'V' or 'X')
                        sum -= 1;
                    else
                        sum += 1;
                    break;
                case 'V':
                    sum += 5;
                    break;
                case 'X':
                    if (nextChar is 'L' or 'C')
                        sum -= 10;
                    else
                        sum += 10;
                    break;
                case 'L':
                    sum += 50;
                    break;
                case 'C':
                    if (nextChar is 'D' or 'M')
                        sum -= 100;
                    else
                        sum += 100;
                    break;
                case 'D':
                    sum += 500;
                    break;
                case 'M':
                    sum += 1000;
                    break;
            }
        }
        
        return sum;
    }

    public int SolveWithDictionary(string s)
    {
        var romanTranslation = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        var sum = 0;

        s = s.Replace("IV", "IIII");
        s = s.Replace("IX", "VIIII");
        s = s.Replace("XL", "XXXX");
        s = s.Replace("XC", "LXXXX");
        s = s.Replace("CD", "CCCC");
        s = s.Replace("CM", "DCCCC");

        foreach (var t in s)
        {
            sum += romanTranslation[t];
        }
        return sum;
    }
}