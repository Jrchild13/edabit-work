<Query Kind="Program" />

/*
	  Create a function that takes a string
	and checks if it has the same number of x's and o's. If so return true,
	if not then return false
*/

void Main()
{
	XO("ooOxxx").Dump();
}

public bool XO(string str)
{	
	int xCount = 0;
	int oCount = 0;
	foreach (char letter in str)
	{
		if (letter == 'x' || letter == 'X') 
		{
			xCount++;
		}
		if (letter == 'o' || letter == 'O') 
		{
			oCount++;
		}
	}
	if (xCount == oCount)
	{
		return true;
	}
	return false;
}

// You can define other methods, fields, classes and namespaces here