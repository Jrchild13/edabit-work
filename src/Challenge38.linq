<Query Kind="Program" />

/*
	Create a function that takes a whole number as input and returns
	the shape with that number's amount of sides
*/

void Main()
{
	NSidedShape(8).Dump();
}

public string NSidedShape(int n)
{
	string[] shapes = {
		"circle",
		"semi-circle",
		"triangle",
		"square",
		"pentagon",
		"hexagon",
		"heptagon",
		"octagon",
		"nonagon",
		"decagon"};
	return shapes[n-1];
}

// You can define other methods, fields, classes and namespaces here