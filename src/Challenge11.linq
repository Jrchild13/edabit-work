<Query Kind="Program" />

/*
Sum of Polygon Angles- Given an n-sided regular polygon n,
return the total sum of internal angles (in degrees).
*/

void Main()
{
	SumOfPolygon(5).Dump();
}

public static double SumOfPolygon(int n)
{
	return (n - 2) * 180;
}