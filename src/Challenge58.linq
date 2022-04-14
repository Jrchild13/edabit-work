<Query Kind="Program" />

/*
	 Create a function that test whether or not an integer is 
	a perfect number. A perfect number is a number that can be written as the sum
	of it's factors, (equal to sum of it's proper divisors) excluding itself.
	
	example:
		- 6 is a perfect number since (1 + 2 + 3 = 6) where 1, 2, and 3 are all factors of 6
		- 12 is not a perfect number since (1 + 2 + 3 + 4 + 6 = 16)
*/

void Main()
{
	CheckPerfect(97).Dump();
}

public bool CheckPerfect(int n)
{
	int value = 0;
	int[] num = new int[1];
	num[0] = n;
	for (int i = 1; i < num.Max(); i++)
	{
		if (num[0] % i == 0)
		{
			value = value + i;
		}
	}
	if (value == n)
	{
		return true;
	}
	return false;
}

// You can define other methods, fields, classes and namespaces here