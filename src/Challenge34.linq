<Query Kind="Program" />

/*
	Given an array of numbers, calculate the mean (average) of the array
*/

void Main()
{
	Mean(new int[] {1, 0, 4, 5, 2 ,4, 1, 2, 3, 3, 3}).Dump();
}

public double Mean(int[] arr)
{
	List<int> nums = new List<int>();
	decimal added = 0;
	foreach (int num in arr)
	{
		added = added + num;
		nums.Add(num);
	}
	decimal average = Math.Round((added / nums.Count()), 2);
	return (double)average;
}

// You can define other methods, fields, classes and namespaces here