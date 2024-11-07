namespace MyWorld;

public class CalculatorParser : IParser<int>
{
    public bool TryParse(string input, out int output)
    {
        return Calculator.TryParse(input, out output);
    }
}
