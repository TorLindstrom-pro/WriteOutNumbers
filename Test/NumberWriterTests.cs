using WriteOutNumbers;

namespace Test;

public class NumberWriterTests
{
    [Theory(DisplayName = "Inputting number 0 should write out 'zero'")]
    [InlineData(0, "zero")]
    [InlineData(1, "one")]
    public void GivenNumber0_ShouldWriteOutZero(int number, string? expectedString)
    {
        // act
        var result = NumberWriter.WriteOut(number);
        
        // assert
        Assert.Equal(expectedString, result);
    }
}