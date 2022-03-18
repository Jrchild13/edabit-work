<Query Kind="Expression" />

/*
Area of a Rectangle- Create a function that 
calculates the area of a rectangle. If the 
arguments are invalid, your function must return -1.
*/

void Main()
{
	Frames(10, 25).Dump();
}

public static double Area(double h, double w)
{
	if (h * w <= 0) { return -1; }
	return h * w;
}