<Query Kind="Program" />

/*
	Using recursion, find the sum of the first (n) natural numbers
*/

void Main()
{
	Sum(12).Dump();
}

public int Sum(int n)
{
	if (n == 0)
	{
		return 0;
	}
	return n + Sum(n-1);
}

// You can define other methods, fields, classes and namespaces here