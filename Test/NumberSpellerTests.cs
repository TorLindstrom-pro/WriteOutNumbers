using WriteOutNumbers;

namespace Test;

public class NumberSpellerTests
{
	[Theory(DisplayName = "Inputting a number should spell out that number")]
	[InlineData(0, "zero")]
	[InlineData(1, "one")]
	[InlineData(2, "two")]
	[InlineData(3, "three")]
	[InlineData(4, "four")]
	[InlineData(5, "five")]
	[InlineData(6, "six")]
	[InlineData(7, "seven")]
	[InlineData(8, "eight")]
	[InlineData(9, "nine")]
	[InlineData(10, "ten")]
	[InlineData(11, "eleven")]
	[InlineData(12, "twelve")]
	[InlineData(13, "thirteen")]
	[InlineData(14, "fourteen")]
	[InlineData(15, "fifteen")]
	[InlineData(16, "sixteen")]
	[InlineData(17, "seventeen")]
	[InlineData(18, "eighteen")]
	[InlineData(19, "nineteen")]
	[InlineData(20, "twenty")]
	public void GivenANumber_ShouldSpellOutTheNumber(int number, string? expectedString)
	{
		// act
		var result = NumberSpeller.SpellOut(number);

		// assert
		Assert.Equal(expectedString, result);
	}
}