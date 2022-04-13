<Query Kind="Program" />

/*
	  Creat a circle constructor that creates a circle
	with a radius provided by an argument. 
	
	Circle Area formula: (PI*r^2)
	Circle Perimeter formula: (2*PI*r)
*/

void Main()
{
	Circle circy = new Circle(11);
	circy.GetArea().Dump();
	
	Circle circ = new Circle(4.44);
	circ.GetPerimeter().Dump();
}
class Circle
{
	public double Radius;
	public Circle(double radius)
	{
		Radius = radius;
	}
	public double GetArea()
	{
		return Math.PI * Radius * Radius;
	}
	public double GetPerimeter()
	{
		return 2 * Math.PI * Radius;
	}
}

// You can define other methods, fields, classes and namespaces here