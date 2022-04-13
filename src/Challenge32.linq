<Query Kind="Program" />

/*
	Given the exponent (power), minimum value (min), and maximum value(max),
	return the number of positive values raised to the N'th power that 
	are within the min and max values
*/

void Main()
{
	PowerRanger(4, 250, 1300).Dump();
}

public int PowerRanger(int power, int min, int max)
{
	int matches = 0;
	
	for (int i = 0; i < max; i++)
	{
		if (Math.Pow(i, power) >= min && Math.Pow(i, power) <= max)
		{
			matches++;
		}
	}
	return matches;
}

// You can define other methods, fields, classes and namespaces here