using Xunit;

namespace Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        double amout = Program.Converter("2156");

        Assert.Equal(amout,2156);
    }
}