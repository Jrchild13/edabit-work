<Query Kind="Program" />

void Main()
{
	Convert(120).Dump();
}

// You can define other methods, fields, classes and namespaces here


public int Convert(int minutes)
{
	return minutes * 60;
}