namespace MyWorld.ConsoleApp;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Select an option: ");
        Console.WriteLine("1. Test Bubble Sort");
        Console.WriteLine("2. Test thermostat event publisher");

        //Paramaterless statement lambda
        Func<string> getuserInput = () =>
        {
            string? input;
            do
            {
                Console.Write("Enter choice: ");
                input = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(input));
            return input!;
        };

        string? choice = getuserInput();

        switch (choice)
        {
            case "1":
                TestBubbleSort();
                break;

            case "2":
                TestThermostat();
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    public static void TestBubbleSort()
    {
        int[] items = new int[5];

        for (int i = 0; i < items.Length; i++)
        {
            Console.Write("Enter an integer: ");
            string? text = Console.ReadLine();
            if (!int.TryParse(text, out items[i]))
            {
                Console.WriteLine($"'{text}' is not a valid integer.");
                return;
            }
        }

        BubbleSortDelegate.BubbleSort(items, BubbleSortDelegate.AlphabeticalGreaterThan);

        Console.WriteLine($"{Environment.NewLine}Alphabetical greater than sorting: ");

        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i]);
        }

        // Anonymous lambda functions are mostly good for when code reusability isn't necessary.
        BubbleSortDelegate.BubbleSort(items, (int first, int second) =>
        {
            return first.ToString().CompareTo(second.ToString()) < 0;
        });

        Console.WriteLine($"{Environment.NewLine}Alphabetical less than sorting: ");

        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i]);
        }

        BubbleSortDelegate.BubbleSort(items, BubbleSortDelegate.GreaterThan);

        Console.WriteLine($"{Environment.NewLine}Numerical greater than sorting: ");
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i]);
        }

        // Passing a Delegate with an Expression Lambda
        BubbleSortDelegate.BubbleSort
            (items, (int first, int second) => first < second);

        Console.WriteLine($"{Environment.NewLine}Numerical less than sorting: ");

        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i]);
        }
    }

    public static void TestThermostat()
    {
        ThermostatEventPublisher thermostat = new();
        HeaterDelegate heater = new(60);
        CoolerDelegate cooler = new(80);

        // These are my two subscribers
        thermostat.OnTemperatureChange += heater.OnTemperatureChanged;
        thermostat.OnTemperatureChange += cooler.OnTemperatureChanged;

        Console.Write("Enter temperature: ");
        string? temperature = Console.ReadLine();
        if (!int.TryParse(temperature, out int currentTemperature))
        {
            Console.WriteLine($"'{temperature}' is not a valid integer.");
            return;
        }
        thermostat.CurrentTemperature = currentTemperature;
    }
}