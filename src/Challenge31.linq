<Query Kind="Program" />

/*
	Given an array of arrays, find the largest number
	within each array and display the results inside
	another array
*/

void Main()
{
	List<int[]> bigNums = new List<int[]>();
	int[] x = {4, 2, 7, 1};
	int[] y = {20, 70, 40, 90};
	int[] z = {1, 2, 0};
	bigNums.Add(x);
	bigNums.Add(y);
	bigNums.Add(z);
	FindLargest(bigNums).Dump();
}

public List<int> FindLargest(List<int[]> bigNumList)
{
	List<int> largestNums = new List<int>();
	largestNums.Add(bigNumList[0].Max());
	largestNums.Add(bigNumList[1].Max());
	largestNums.Add(bigNumList[2].Max());	
	return largestNums;
}
