using WriteOutNumbers;

namespace Test;

public class NumberWriterTests
{
    [Fact(DisplayName = "Inputting number 0 should write out 'zero'")]
    public void GivenNumber0_ShouldWriteOutZero()
    {
        // act
        var result = NumberWriter.WriteOut(0);
        
        // assert
        Assert.Equal("zero", result);
    }
}