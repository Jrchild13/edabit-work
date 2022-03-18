# Return the Remainder from Two Numbers- There is a single operator in C#, capable of providing the remainder of a division operation. Two numbers are passed as parameters. The first parameter divided by the second parameter will have a remainder, possibly zero. Return that value.

public class Program
{
	public static int remainder(int x, int y)
	{
		return x % y;
	}
}
# Find the Perimeter of a Rectangle- Create a function that takes length and width and finds the perimeter of a rectangle.

public class Program
{
	public static double findPerimeter(double length, double width)
	{
		return (length * 2) + (width * 2);
	}
}
# Return Something to Me!- Write a function that returns the string "something" joined with a space " " and the given argument a.

public class Program
{
	public static string giveMeSomething(string a)
	{
		return "something " + a;
	}
}
# Is the Number Less than or Equal to Zero?-  Create a function that takes a number as its only argument and returns true if it's less than or equal to zero, otherwise return false.

public class Program
{
	public static bool lessThanOrEqualToZero(int num)
	{
		if (num <= 0) {return true;}
    return false;
	}
}
# Sum of Polygon Angles- Given an n-sided regular polygon n, return the total sum of internal angles (in degrees).

public class Program
{
	public static double sumPolygon(int n)
	{
		return (n - 2) * 180;
	}
}
# Basketball Points- You are counting points for a basketball game, given the amount of 2-pointers scored and 3-pointers scored, find the final points for the team and return that value.

public class Program
{
	public static int points(int twoPointers, int threePointers)
	{
		return (twoPointers * 2) + (threePointers * 3);
	}
}
# Basic Variable Assignment- A student learning JavaScript was trying to make a function. His code should concatenate a passed string name with string "Edabit" and store it in a variable called result. He needs your help to fix this code.

public class Program
{
	public static string nameString(string name)
	{
		string b = "Edabit";
    string result = name + b;
    return result;
	}
}
# Less Than 100?- Given two numbers, return true if the sum of both numbers is less than 100. Otherwise return false.

public class Program
{
	public static bool lessThan100(int a, int b)
	{
		if (a + b < 100) {return true;}
    return false;
	}
}
# The Farm Problem- In this challenge, a farmer is asking you to tell him how many legs can be counted among all his animals. The farmer breeds three species:

# -chickens = 2 legs
# -cows = 4 legs
# -pigs = 4 legs
# The farmer has counted his animals and he gives you a subtotal for each species. You have to implement a function that returns the total number of legs of all the animals.

public class Program
{
	public static int animals(int chickens, int cows, int pigs)
	{
		return (chickens * 2) + (cows * 4) + (pigs * 4);
	}
}
# Are the Numbers Equal?- Create a function that returns true when num1 is equal to num2; otherwise return false.

public class Program
{
	public static bool isSameNum(int num1, int num2)
	{
		if (num1 == num2) {return true;}
    return false;
	}
}

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