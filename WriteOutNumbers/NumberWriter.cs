namespace WriteOutNumbers;

public abstract class NumberWriter
{
	public static string WriteOut(int number)
	{
		return number == 0 ? "zero" : "one";
	}
}