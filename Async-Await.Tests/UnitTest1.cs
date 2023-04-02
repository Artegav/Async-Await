namespace Async_Await.Tests;

public class UnitTest1
{
    [Fact]
    public void TenRandomIntsTest()
    {
        //Arrange
        int size = 10;

        //Act
        int[] array = TenRandomIntsAsync().Result;

        //Assert
        array.ShouldSatisfyAllConditions(
            () => array.ShouldNotBeNull(),
            () => array.Length.ShouldBe(size),
            () => array.ShouldAllBe(x => x >= 1 && x <= 100)
        );
    }

    [Fact]
    public void SortArrayByAscendingTest()
    {
        //Arrange
        int[] array = new[] { 5, 3, 8, 1, 7 };
        int[] expected = new[] { 1, 3, 5, 7, 8 };

        //Act
        int[] result = SortAscendingAsync(array).Result;

        //Assert
        result.ShouldBe(expected);
    }

    [Fact]
    public void CalculateAverageValueTest()
    {
        //Arrange
        int[] array = new[] { 2, 4, 6, 8 };

        //Act
        double result = GetAverageValueAsync(array).Result;

        //Assert
        result.ShouldBe(5);
    }
}
