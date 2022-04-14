<Query Kind="Program" />

/*
	 Imagine a circle and two squares: a smaller and a bigger one.
	For the smaller one, the circle is a circumcircle and for the bigger one, an incircle.
	Create a function, that takes an integer (radius of the circle) and returns the
	difference of the areas of the two squares.
*/

void Main()
{
	SquareAreasDifference(7).Dump();
}

public int SquareAreasDifference(int radius)
{
	double bigger = Math.Pow((radius + radius), 2);
	int small = (radius * radius) * 2;
	return Convert.ToInt32(bigger) - small;
}

// You can define other methods, fields, classes and namespaces here