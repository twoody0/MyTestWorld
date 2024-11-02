namespace MyWorld.ConsoleApp;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Select an option: ");
        Console.WriteLine("1. Test Bubble Sort");

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

        Console.WriteLine("Alphabetical greater than sorting: ");

        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i]);
        }

        BubbleSortDelegate.BubbleSort(items, (int first, int second) =>
        {
            return first.ToString().CompareTo(second.ToString()) < 0;
        });

        // Anonymous lambda functions are mostly good for when code reusability isn't necessary.

        Console.WriteLine("Alphabetical less than sorting: ");

        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i]);
        }

        BubbleSortDelegate.BubbleSort(items, BubbleSortDelegate.GreaterThan);

        Console.WriteLine("Numerical greater than sorting: ");
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i]);
        }

        BubbleSortDelegate.BubbleSort
            (items, (int first, int second) => first < second);

        // Passing a Delegate with an Expression Lambda

        Console.WriteLine("Numerical less than sorting: ");

        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i]);
        }
    }
}