<Query Kind="Program" />

/*
	 Write a function that returns true if (k^k == n)
	for input (n, k) and return false if otherwise
*/

void Main()
{
	KTok("4", 3).Dump();
}

public bool KTok(string n, int k)
{
	if (n == Math.Pow(k, 2).ToString())
	{
		return true;
	}
	return false;
}

// You can define other methods, fields, classes and namespaces here