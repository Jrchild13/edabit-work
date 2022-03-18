# Divides Evenly- Given two integers, a and b, return true if a can be divided evenly by b. Return false otherwise.

public class Program
{
	public static int dividesEvenly(int a, int b)
	{
		if (a%b == 0 ) { return true; }
	return false;
	}
}
# Area of a Rectangle- Create a function that calculates the area of a rectangle. If the arguments are invalid, your function must return -1.

public class Program
{
	public static double area(double h, double w)
	{
		if (h * w <= 0) { return -1; }
    return h * w;
	}
}
# Concatenate First and Last Name into One String- Given two strings, firstName and lastName, return a single string in the format "last, first".

public class Program
{
	public static string ConcatName(string firstName, string lastName)
	{
		return lastName + ", " + firstName;
	}
}