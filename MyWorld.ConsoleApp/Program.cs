namespace MyWorld.ConsoleApp;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Select an option: ");
        Console.WriteLine("1. Bubble Sort Test");
        Console.Write("Enter choice: ");

        string? choice = Console.ReadLine();
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

        //BubbleSortDelegate.BubbleSort(items, BubbleSortDelegate.AlphabeticalGreaterThan);

        BubbleSortDelegate.BubbleSort(items, (int first, int second) =>
        {
            return first < second;
        });

        // Lambda functions are mostly good for when code reusability isn't necessary.

        Console.WriteLine("Alphabetical greater than comparison: ");
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i]);
        }

        BubbleSortDelegate.BubbleSort(items, BubbleSortDelegate.GreaterThan);
        Console.WriteLine("Numerical greater than comparison: ");
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i]);
        }
    }
}