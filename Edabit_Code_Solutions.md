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