<Query Kind="Program" />

/*
	Create a function that takes an array
	of items, removes duplicate items and returns a new array in the same
	sequentil order as the old array(minus the duplicates)
*/

void Main()
{
	RemoveDups(new object[] {1, 4, 1, "The", "big", "cat", 3, 5, 3}).Dump();
}

public object[] RemoveDups(object[] arr)
{
	IEnumerable<object> noDups = arr.Distinct();
	return noDups.ToArray();
}

// You can define other methods, fields, classes and namespaces here