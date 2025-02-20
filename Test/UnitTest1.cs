using WriteOutNumbers;

namespace Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // act
        var result = NumberWriter.WriteOut(0);
        
        // assert
        Assert.Equal("zero", result);
    }
}