using Xunit;
namespace TestHHRU;


public class UnitTest1
{
    Fact]
    public void CircleCalculateAreaTest()
    {
        var circle = new Circle { Radius = 5 };
        Assert.Equal(Math.PI * 25, circle.CalculateArea());
    }

    [Fact]
    public void TriangleCalculateAreaTest()
    {
        var triangle = new Triangle { SideA = 3, SideB = 4, SideC = 5 };
        Assert.Equal(6, triangle.CalculateArea());
    }

    [Fact]
    public void TriangleIsRightTest()
    {
        var triangle = new Triangle { SideA = 3, SideB = 4, SideC = 5 };
        Assert.True(triangle.IsRightTriangle());
    }
}