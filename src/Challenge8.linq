<Query Kind="Program" />

/*
Find the Perimeter of a Rectangle- Create a function
that takes length and width and finds the perimeter of a rectangle.
*/

void Main()
{
	FindPerimeter(2, 3).Dump();
}

public static double FindPerimeter(double length, double width)
{
		return (length * 2) + (width * 2);
}