using System.Text.RegularExpressions;

public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        input = input.Replace(" ", "");
        Regex rgx = new Regex(@"(?!\(|\))\S");
        input = rgx.Replace(input, "");

        while (input.Contains("()") && input.Length > 0)
        {
            input = input.Replace("()", "");
        }

        if (string.IsNullOrEmpty(input))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}