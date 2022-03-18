# Football Points- Create a function that takes the number of wins, draws and losses and calculates the number of points a football team has obtained so far.
# -wins get 3 points
# -draws get 1 point
# -losses get 0 points

public class Program
{
	public static int footballPoints(int wins, int draws, int losses)
	{
		return (wins * 3) + draws;
	}
}
# Convert Hours and Minutes into Seconds- Write a function that takes two integers (hours, minutes), converts them to seconds, and adds them.

public class Program
{
	public static double convert(int hours, int minutes)
	{
		return (hours * 3600) + (minutes * 60);
	}
}
# Profitable Gamble- Create a function that takes three arguments prob, prize, pay and returns true if prob * prize > pay; otherwise return false.

public class Program
{
	public static bool profitableGamble(double prob, double prize, double pay)
	{
		if (prob * prize > pay) {return true;}
    return false;
	}
}
# Boolean to String Conversion- Create a function that takes a boolean variable flag and returns it as a string.

public class Program
{
	public static string boolToString(bool true)
	{
		return true.ToString();
	}
}
# Frames Per Second- Create a function that returns the number of frames shown in a given number of minutes for a certain FPS.

public class Program
{
	public static int frames(int minutes, int fps)
	{
		return (minutes * fps) * 60;
	}
}
# Two Makes Ten- Create a function that takes two arguments. Both arguments are integers, a and b. Return true if one of them is 10 or if their sum is 10.

public class Program
{
	public static bool makesTen(int a, int b)
	{
		if (a + b == 10 || a == 10 || b == 10) {return true;}
    return false;
	}
}
# Let's Fuel Up!- A vehicle needs 10 times the amount of fuel than the distance it travels. However, it must always carry a minimum of 100 fuel before setting off.Create a function which calculates the amount of fuel it needs, given the distance.

public class Program
{
	public static double calculateFuel(int n)
	{
		if (n * 10 < 100) { return 100; }
    return n * 10;
	}
}
# Compare Strings by Count of Characters- Create a function that takes two strings as arguments and return either true or false depending on whether the total number of characters in the first string is equal to the total number of characters in the second string.

public class Program
{
	public static bool comp(string str1, string str2)
	{
		if (str1.Length == str2.Length) { return true; }
    return false;
	}
}
>>>>>>> 051785ab3e01d657de0ebd01fa867cf84f995550
# Check if an Integer is Divisible By Five- Create a function that returns true if an integer is evenly divisible by 5, and false otherwise.

public class Program
{
	public static bool divisibleByFive(int n)
	{
		if (n%5 == 0 ) { return true; }
	return false;
	}
}
 # Multiple of 100- Create a function that takes an integer and returns true if it's divisible by 100, otherwise return false.

public class Program
{
	public static bool divisible(int num)
	{
		if (num%100 == 0 ) { return true; }
	return false;
	}
}
# Recursion: Length of a String- Write a function that returns the length of a string. Make your function recursive.

public class Program
{
	public static int length(string str)
	{
		return Convert.ToInt32(str.Length);
	}
}
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