namespace WriteOutNumbers;

public abstract class NumberSpeller
{
	public static string SpellOut(int number)
	{
		return SpellNumberWithMultipleDigits(number);
	}

	private static string SpellNumberWithMultipleDigits(int number)
	{
		return number switch
		{
			>= 0 and <= 9 => SpellOutSingleDigit(number),
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
			>= 21 and <= 29 => $"twenty{AppendEventualSecondNumber(number % 10)}",
			>= 30 and <= 39 => $"thirty{AppendEventualSecondNumber(number % 10)}",
		};
	}

	private static string AppendEventualSecondNumber(int number)
	{
		return number == 0 ? "" : $"-{SpellOutSingleDigit(number)}";
	}

	private static string SpellOutSingleDigit(int number)
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
			9 => "nine"
		};
	}
}