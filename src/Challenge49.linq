<Query Kind="Program" />

/*
	A quadratic equation has either 
	0, 1, or 2 distinct solutions for real values of x. Given a, b, and c, return the 
	number of solutions to the equation.
	
	quadratic equation formula:
	 	a * x^2 + b * x + c = 0
*/

void Main()
{
	Solutions(1000, 1000, 0).Dump();
}

public int Solutions(int a, int b, int c)
{
	if (b * b - 4 * a * c > 0)
	{
		return 2;
	}
	else if (b * b -4 * a * c == 0)
	{
		return 1;
	}
	return 0;
}

// You can define other methods, fields, classes and namespaces here