<Query Kind="Program" />

/*
Area of a Triangle- Write a function that 
takes the base and height of a triangle and return its area.
*/

void Main()
{
	TriArea(5, 4).Dump();
}

public double TriArea(double bottom, double height)
{
	return (bottom * height) / 2;
}