<Query Kind="Expression" />

/*
Basketball Points- You are counting points for a basketball game,
given the amount of 2-pointers scored and 3-pointers scored,
find the final points for the team and return that value.
*/

void Main()
{
	Points(3, 2).Dump();
}

public static int Points(int twoPointers, int threePointers)
{
	return (twoPointers * 2) + (threePointers * 3);
}