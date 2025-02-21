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

	[Theory(DisplayName = "Given a number in the twenties should spell out the number")]
	[InlineData(21, "twenty-one")]
	[InlineData(22, "twenty-two")]
	[InlineData(27, "twenty-seven")]
	[InlineData(29, "twenty-nine")]
	[InlineData(30, "thirty")]
	[InlineData(31, "thirty-one")]
	[InlineData(39, "thirty-nine")]
	[InlineData(40, "forty")]
	[InlineData(41, "forty-one")]
	[InlineData(49, "forty-nine")]
	[InlineData(50, "fifty")]
	[InlineData(59, "fifty-nine")]
	[InlineData(60, "sixty")]
	[InlineData(69, "sixty-nine")]
	[InlineData(70, "seventy")]
	[InlineData(79, "seventy-nine")]
	[InlineData(80, "eighty")]
	[InlineData(89, "eighty-nine")]
	[InlineData(90, "ninety")]
	[InlineData(99, "ninety-nine")]
	public void GivenANumberBetweenTwentyAndNinetyNine_ShouldSpellOutTheNumber(int number, string expectedString)
	{
		// act
		var result = NumberSpeller.SpellOut(number);
		
		// assert
		Assert.Equal(expectedString, result);
	}

	[Theory(DisplayName = "Given a number in the hundreds should spell out the number")]
	[InlineData(100, "one hundred")]
	[InlineData(101, "one hundred one")]
	[InlineData(199, "one hundred ninety-nine")]
	public void GivenHundred_ShouldWriteOutThatNumber(int number, string expectedString)
	{
		// act
		var result = NumberSpeller.SpellOut(number);
		
		// assert
		Assert.Equal(expectedString, result);
	}

	[Fact]
	public void UnsupportedNumber_ShouldThrowError()
	{
		// assert
		Assert.Throws<ArgumentOutOfRangeException>(() => NumberSpeller.SpellOut(-1));
	}
}