namespace MyWorld;

public class PersonParser : IParser<Person?>
{
    public bool TryParse(string input, out Person? output)
    {
        return Person.TryParse(input, out output);
    }
}
