<Query Kind="Program" />

/*
	 Creat a function that takes three
	integer arguments (a, b, c) and return the amount of 
	integers which are of equal value
*/

void Main()
{
	Equal(3, 4, 1).Dump();
}

public int Equal(int a, int b, int c)
{
	if (a == b && b == c)
	{
		return 3;
	}
	if (a == b || b == c || a == c)
	{
		return 2;
	}	
	return 0;
}

// You can define other methods, fields, classes and namespaces here