<Query Kind="Program" />

/*
	Given an array of numbers, remove the odd numbers 
	and return only the even numbers
*/

void Main()
{
	NoOdds(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9}).Dump();
}

public int[] NoOdds(int[] arr)
{
	List<int> evens = new List<int>();
	foreach (int num in arr)
	{
		if (num % 2 == 0)
		{
			evens.Add(num);
		}
	}
	return evens.ToArray();
}

// You can define other methods, fields, classes and namespaces here