<Query Kind="Program" />

/*
	 Create a function that checks if a given 
	integer is exactly the factorial of an integer or not. If it is then return 
	true, if it isn't then return false
*/

void Main()
{
	IsFactorial(2).Dump();
}

public bool IsFactorial(int n)
{
	if (n % 2 == 1)
	{
		return false;
	}
	for (int i = 2, t = 1; t <= n; t *= i++)
		if (t == n)
		{
			return true;
		}
	return false;
}

// You can define other methods, fields, classes and namespaces here