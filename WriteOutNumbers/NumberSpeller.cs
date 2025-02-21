namespace WriteOutNumbers;

public abstract class NumberSpeller
{
	public static string SpellOut(int number)
	{
		if (number > 20)
		{
			return SpellNumberGreaterThan20(number);
		}
		return SpellNumberNoBiggerThan20(number);
	}

	private static string SpellNumberGreaterThan20(int number)
	{
		return "twenty-one";
	}

	private static string SpellNumberNoBiggerThan20(int number)
	{
		return number switch
		{
			0 => "zero",
			1 => "one",
			2 => "two",
			3 => "three",
			4 => "four",
			5 => "five",
			6 => "six",
			7 => "seven",
			8 => "eight",
			9 => "nine",
			10 => "ten",
			11 => "eleven",
			12 => "twelve",
			13 => "thirteen",
			14 => "fourteen",
			15 => "fifteen",
			16 => "sixteen",
			17 => "seventeen",
			18 => "eighteen",
			19 => "nineteen",
			20 => "twenty",
		};
	}
}