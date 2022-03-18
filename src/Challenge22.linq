<Query Kind="Expression" />

/*
Two Makes Ten- Create a function that takes two arguments.
Both arguments are integers, a and b. Return true if one of 
them is 10 or if their sum is 10.
*/

void Main()
{
	MakesTen(3, 6).Dump();
}

public static bool MakesTen(int a, int b)
{
	if (a + b == 10 || a == 10 || b == 10) { return true; }
	return false;
}