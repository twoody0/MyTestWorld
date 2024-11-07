namespace MyWorld;

public class Calculator : IStringParser<int>
{
    public static bool TryParse(string input, out int output)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            output = default;
            return false;
        }
        output = 2;
        return true;
    }
}
