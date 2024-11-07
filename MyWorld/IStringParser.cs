namespace MyWorld;

public interface IStringParser<TOutput>
{
    static abstract bool TryParse(string input, out TOutput output);
}