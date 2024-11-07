namespace MyWorld;

public record class Person : IStringParser<Person?>
{
    public string FirstName { get; }
    public string LastName { get; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public static bool TryParse(string input, out Person? output)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            output = default;
            return false;
        }

        if (input.Split(' ').Length != 2)
        {
            output = default;
            return false;
        }
        else
        {
            string[]? parts = input.Split(' ');
            output = new Person(parts[0], parts[1]);
            return true;
        }
    }
}
