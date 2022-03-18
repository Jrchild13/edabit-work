<Query Kind="Program" />

/*
Less Than 100?- Given two numbers, return true if
the sum of both numbers is less than 100. Otherwise return false.
*/

void Main()
{
	LessThan100(35, 65).Dump();
}

public static bool LessThan100(int a, int b)
{
	if (a + b < 100) { return true; }
	return false;
}