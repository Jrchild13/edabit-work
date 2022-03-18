<Query Kind="Expression" />

/*
Maximum Edge of a Triangle- Create a function that finds 
the maximum range of a triangle's third edge, where the 
side lengths are all integers.
*/

void Main()
{
	CalcAge(22).Dump();
}

public static int NextEdge(int side1, int side2)
{
	return (side1 + side2) -1;
}