<Query Kind="Program" />

/*
	  Create a function that returns the number of 
	hashes and pluses in a string using this format: [hashes#, pluses#]
*/

void Main()
{
	HashPlusCount("#+##+#+").Dump();
}

public int[] HashPlusCount(string str)
{
	int[] symbols = new int[2];
	foreach (char letter in str)
	{
		if (letter == '#')
		{
			symbols[0]++;
		}
		if (letter == '+')
		{
			symbols[1]++;
		}
	}
	return symbols;
}

// You can define other methods, fields, classes and namespaces here