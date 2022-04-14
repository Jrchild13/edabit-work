<Query Kind="Program" />

/*
	 Create a function that takes an array
	of numbers and returns the sum of the two lowest positive numbers
*/

void Main()
{
	SumSmallest(new int[] { 19, 5, 42, 2, 77}).Dump();
}

public int SumSmallest(int[] arr)
{
	int min1 = arr[0];
	int min2 = arr[1];
	if (min2 < min1)
	{
		min1 = arr[1];
		min2 = arr[0];
	}
	for (int i = 2; i < arr.Length; i++)
		if (arr[i] < min1 && arr[i] > 0)
		{
			min2 = min1;
			min1 = arr[i];
		}
		else if (arr[i] < min2 && arr[i] > 0)
		{
			min2 = arr[i];
		}
	return min1 + min2;

}

// You can define other methods, fields, classes and namespaces here