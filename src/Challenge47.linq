<Query Kind="Program" />

/*
		Create a function that searches for the index
	of a give item in an array using recursion. If the item is present,
	it should return the index that the number is located at. Otherwise 
	it should return -1.
*/

void Main()
{
	Search(new int[] { -1, 3, 5, 7, 9}, 11).Dump();
}

public int Search(int[] arr, int item)
{
	int index = Array.IndexOf(arr, item);
	if (index < 0)
	{
		return -1;
	}
	return index;
}

// You can define other methods, fields, classes and namespaces here