<Query Kind="Program" />

/*
	 Create a function that takes an array of 
	positive and negative numbers, and return an array where the first element
	is the count of positive numbers and the second element is the sum of negative
	numbers
*/

void Main()
{
	CountPosSumNeg(new int[] { 91, -4, 80, -73, -28}).Dump();
}

public int[] CountPosSumNeg(int[] arr)
{
	int[] final = new int[2];
	int negative = 0;
	List<int> positive = new List<int>();
	foreach (int num in arr)
	{
		if (num >= 0)
		{
			positive.Add(num);
		}
		else negative = negative + num;
	}
	final[0] = positive.Count();
	final[1] = negative;
	return final;
}

// You can define other methods, fields, classes and namespaces here