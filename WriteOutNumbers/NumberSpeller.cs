using System;

namespace WriteOutNumbers;

public abstract class NumberSpeller
{
	public static string SpellOut(int number) =>
		number switch
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
			>= 21 and <= 29 => $"twenty{AppendEventualSecondNumber(number % 10)}",
			>= 30 and <= 39 => $"thirty{AppendEventualSecondNumber(number % 10)}",
			>= 40 and <= 49 => $"forty{AppendEventualSecondNumber(number % 10)}",
			>= 50 and <= 59 => $"fifty{AppendEventualSecondNumber(number % 10)}",
			>= 60 and <= 69 => $"sixty{AppendEventualSecondNumber(number % 10)}",
			>= 70 and <= 79 => $"seventy{AppendEventualSecondNumber(number % 10)}",
			>= 80 and <= 89 => $"eighty{AppendEventualSecondNumber(number % 10)}",
			>= 90 and <= 99 => $"ninety{AppendEventualSecondNumber(number % 10)}",
			>= 100 and <= 999 => SpellNumberInTheHundreds(number),
			>= 1000 and <= 999999 => SpellNumberInTheThousands(number),
			_ => throw new ArgumentOutOfRangeException()
		};

	private static string SpellNumberInTheHundreds(int number) => 
		$"{SpellOut(number / 100)} hundred{AppendEventualSecondNumber(number % 100, false)}";

	private static string SpellNumberInTheThousands(int number) => 
		$"{SpellOut(number / 1000)} thousand{AppendEventualSecondNumber(number % 1000, false)}";

	private static string AppendEventualSecondNumber(int number, bool shouldAppendHyphen = true)
	{
		if (number == 0)
			return "";

		return (shouldAppendHyphen ? "-" : " ") + SpellOut(number);
	}
}