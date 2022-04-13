<Query Kind="Program" />

/*
	Given 2 numbers (a) and (b), create a function that
	returns the next number greater than (a) and 
	divisible by (b).
*/

void Main()
{
	DivisibleBy(14, 11).Dump();
}

public int DivisibleBy(int a, int b)
{
	int num = 0;
	for (int i = a; i >= a; i++)
	{
		if (i % b == 0)
		{
			num = num + i;
			break;
		}
	}
	return num;
}

// You can define other methods, fields, classes and namespaces here