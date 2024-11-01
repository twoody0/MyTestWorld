namespace MyWorld.ConsoleApp;

public static class Program
{
    public static void Main()
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