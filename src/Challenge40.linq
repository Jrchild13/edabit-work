<Query Kind="Program" />

/*
	Given an array of numbers, create a function that returns
	true if the average is a whole numbers and false if the 
	average is a decimal number
*/

void Main()
{
	IsAvgWhole(new int[] { 9, 2, 2, 5}).Dump();
}

public bool IsAvgWhole(int[] arr)
{
	int added = 0;
	foreach (int num in arr)
	{
		added = added + num;
	}
	double total = added % arr.Length;
	if ( total == 0)
	{
		return true;
	}
	return false;
}

// You can define other methods, fields, classes and namespaces here