<Query Kind="Program" />

/*
	Given an array of numbers, determine if the elements in the array
	are consecutive. If they are then return True, if not then return false.
*/

void Main()
{
	Cons(new int[] {5, 1, 4, 6, 2}).Dump();
}

public bool Cons(int[] arr)
{
	Array.Sort(arr);
	var arrayData = arr[0];
	for (int i = 0; i < arr.Length; i++)
	{
		if (i != 0)
		{
			if (arr[i] - arrayData == 1)
			{
				arrayData = arr[i];
			}
			else return false;
		}
	}
	return true;
}

// You can define other methods, fields, classes and namespaces here