<Query Kind="Program" />

/*
	Given a number (num) and the desired length (length),
	display each multiple in an array until the desired
	length has been reached
*/

void Main()
{
	ArrayOfMultiples(12,10).Dump();
}

 public static object[] ArrayOfMultiples(int num, int length)
{
	ArrayList numsList = new ArrayList();
	for (int x = 1; x <= length; x++)
	{
		int nums = num * x;
		numsList.Add(nums);
	}
	return numsList.ToArray();
} 