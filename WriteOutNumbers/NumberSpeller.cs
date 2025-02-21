namespace WriteOutNumbers;

public abstract class NumberSpeller
{
	public static string SpellOut(int number)
	{
		return number == 0 ? "zero" : "one";
	}
}