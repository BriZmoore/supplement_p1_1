namespace supplement_p1_1.Tests;

public class UnitTest1
{
    [Fact]
    public void ShouldCalculateAreaOfRectangleWithDifferentLengthAndWidth()
    {
        Assert.True(50.0 == supplement_p1_1.AreaofRectangle(5.0, 10.0));
    }
      [Fact]
    public void ShouldCalculateAreaOfRectangleWithSameLengthAndWidth()
    {
        Assert.True(25.0 == supplement_p1_1.AreaofRectangle(5.0, 5.0));
    }
      [Fact]
    public void ShouldCalculateAreaOfUnitCircle()
    {
        Assert.True(double.Pi== supplement_p1_1.AreaCircle(1.0));
    }
}