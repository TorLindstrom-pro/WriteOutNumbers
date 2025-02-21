using WriteOutNumbers;

namespace Test;

public class NumberSpellerTests
{
    [Theory(DisplayName = "Inputting number 0 should spell out 'zero'")]
    [InlineData(0, "zero")]
    [InlineData(1, "one")]
    public void GivenNumber0_ShouldSpellOutZero(int number, string? expectedString)
    {
        // act
        var result = NumberSpeller.SpellOut(number);
        
        // assert
        Assert.Equal(expectedString, result);
    }
}