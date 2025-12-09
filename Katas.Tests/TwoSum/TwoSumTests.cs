using Xunit;
using Katas.TwoSum;

namespace Katas.Tests.TwoSum;

public class TwoSumTests
{
    [Fact]
    public void Solve_Example1_ReturnsIndices()
    {
        // Arrange
        var solver = new TwoSumSolver();
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        // Act
        int[] result = solver.Solve(nums, target);

        // Assert
        Assert.Equal(new int[] { 0, 1 }, result);
    }
    
    [Fact]
    public void Solve_NoSolution_ReturnsEmpty()
    {
         // Optional: Handle edge cases depending on requirements
         var solver = new TwoSumSolver();
         int[] result = solver.Solve(new int[] { 1, 2 }, 99);
         Assert.Empty(result);
    }
}
