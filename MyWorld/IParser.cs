namespace MyWorld;

public interface IParser<TOutput>
{
    bool TryParse(string input, out TOutput? output);
}