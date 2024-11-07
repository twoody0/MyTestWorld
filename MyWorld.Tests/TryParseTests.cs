namespace MyWorld.Tests;

public class TryParseTests
{
    [Fact]
    public void Calculator_TryParse_ReturnsTrue()
    {
        Calculator calculator = new ();
        void Validate(int result)
        {
            Action validate = () => Assert.Equal(2, result);
        }
        bool condition = TryParseTrue<CalculatorParser, int>(new CalculatorParser(), "1 + 1", out int result, Validate);
        Assert.True(condition);
    }

    [Fact]
    public void Person_TryParse_ReturnsCorrectPerson()
    {
        bool condition = Person.TryParse("John Doe", out Person? result);
        Assert.True(condition);
        Assert.Equal("John", result.FirstName);
        Assert.Equal("Doe", result.LastName);
    }

    private bool TryParseTrue<TParser, TOutput>(TParser parser, string input, out TOutput output, Action<TOutput> validate) where TParser : IParser<TOutput>
    {
        bool condition = parser.TryParse(input, out output);
        Assert.True(condition);
        //call my validation methods (some assert methods of my choice)
        validate(output);
        return condition;
    }
}