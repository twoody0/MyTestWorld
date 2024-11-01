namespace MyWorld;

public class SimpleSort
{
    public enum SortType
    {
        Ascending,
        Descending
    }

    public static void BubbleSort(int[] items, SortType sortOrder)
    {
        if (items is null)
        {
            return;
        }

        for (int i = items.Length - 1; i >= 0; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                bool swap = false;
                switch (sortOrder)
                {
                    case SortType.Ascending:
                        swap = items[j - 1] > items[j];
                        break;

                    case SortType.Descending:
                        swap = items[j - 1] < items[j];
                        break;
                }

                if (swap)
                {
                    int temp = items[j - 1];
                    items[j - 1] = items[j];
                    items[j] = temp;
                }
            }
        }
    }
}