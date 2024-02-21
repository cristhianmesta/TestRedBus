using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TestRedBus.Tests;

public class BikesTest
{

    public static IEnumerable<object[]> TestData => new List<object[]>
    {
        new object[] { new List<int> { 5, 3, 2, 5, 6, 1, 4, 7, 9 }, 10, 4 },
        new object[] { new List<int> { 1, 2, 3, 4, 5 }, 6, 2 },
        new object[] { new List<int> { 2, 2, 3, 4, 5 }, 6, 1 },
        new object[] { new List<int> { }, 4, 0 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void CountBikes_Test(List<int> packages, int totalWeight, int expected)
    {

        int actual = Bikes.CalculateBikes(packages, totalWeight);

        Assert.Equal(expected, actual);
    }
}