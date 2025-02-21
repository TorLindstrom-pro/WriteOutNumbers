﻿using WriteOutNumbers;

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
	public void GivenANumberOverInTheTwenties_ShouldSpellOutTheNumber(int number, string expectedString)
	{
		// act
		var result = NumberSpeller.SpellOut(number);
		
		// assert
		Assert.Equal(expectedString, result);
	}

	[Theory(DisplayName = "Given a number in the thirties should spell out the number")]
	[InlineData(30, "thirty")]
	[InlineData(31, "thirty-one")]
	[InlineData(39, "thirty-nine")]
	public void GivenANumberInTheThirties_ShouldSpellOutTheNumber(int number, string expectedString)
	{
		// act
		var result = NumberSpeller.SpellOut(number);
		
		// assert
		Assert.Equal(expectedString, result);
	}
}