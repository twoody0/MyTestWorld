namespace MyWorld;

public static class BubbleSortDelegate
{
    public static void BubbleSort(int[] items, Func<int, int, bool> compare)
    {
        for (int i = items.Length - 1; i >= 0; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                if (compare(items[j - 1], items[j]))
                {
                    int temp = items[j - 1];
                    items[j - 1] = items[j];
                    items[j] = temp;
                }
            }
        }
    }

    public static bool GreaterThan(int first, int second)
    {
        return first > second;
    }

    public static bool AlphabeticalGreaterThan(int first, int second)
    {
        int comparison = (first.ToString().CompareTo(second.ToString()));

        return comparison > 0;
    }
}