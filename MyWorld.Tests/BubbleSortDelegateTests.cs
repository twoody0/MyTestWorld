namespace MyWorld.Tests;

public class BubbleSortDelegateTests
{
    [Fact]
    public void BubbleSort_ArrayOfNumbers_CorrectlySortsComparedValues()
    {
        // Arrange
        int[] items = { 3, 6, 2, 8, 5 };
        int[] expectedItems = { 2, 3, 5, 6, 8 };

        // Act
        BubbleSortDelegate.BubbleSort(items, BubbleSortDelegate.GreaterThan);

        // Assert
        Assert.Equal(items, expectedItems);
    }
}